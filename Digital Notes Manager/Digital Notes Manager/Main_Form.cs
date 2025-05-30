using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using Digital_Notes_Manager.Models;
using Digital_Notes_Manager.Controller;
using System.IO;


namespace Digital_Notes_Manager
{
    public partial class Main_Form : XtraForm
    {
        public Main_Form()
        {
            InitializeComponent();
            Add_A_New_Note_Accordion_Element.Click += AccordionElementClick;
            Show_Notes_Accordion_Element.Click += AccordionElementClick;
            LoadNotesForm();
        }

        private void AccordionElementClick(object sender, EventArgs e)
        {
            AccordionControlElement accordionControlElement = sender as AccordionControlElement;
            if (accordionControlElement != null)
            {
                switch (accordionControlElement.Name)
                {
                    case "Show_Notes_Accordion_Element":
                        {
                            LoadNotesForm();
                        }
                        break;
                    case "Add_A_New_Note_Accordion_Element":
                        {
                            Note_Form noteForm = new Note_Form();
                            noteForm.Show();
                        }
                        break;

                    default:
                        XtraMessageBox.Show("Unknown action.");
                        break;
                }
            }
        }

        public ViewNotes viewNotes;
        ManageNoteContext manageNoteContext = Utilities.manageNoteContext;


        private void LoadNotesForm()
        {
            this.MDI_Panel.Controls.Clear();
            viewNotes = new ViewNotes();
            MDI_Panel.Controls.Add(viewNotes.panel1);
        }


        private void MDI_Panel_Paint(object sender, PaintEventArgs e)
        {
            //manageNoteContext = new ManageNoteContext();
            //viewNotes = new ViewNotes(manageNoteContext, this);
            //var list = manageNoteContext.Notes.ToList();
            //BindingList<Note> BLN = new BindingList<Note>(list);
            //viewNotes.Notes_Grid.DataSource = BLN;

        }


        private void View_All_Notes_Popped_Click(object sender, EventArgs e)
        {
            var list = manageNoteContext.Notes.ToList();
            for (int i = 0; i < 5; i++)
            {
                Note_Form note_form = new Note_Form();
                note_form.richTextBox1.Text = list[i].Content;
                note_form.Text = list[i].Title;
                note_form.Show();

            }
        }


        private void importNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                Filter = "Rich Text Files (*.rtf)|*.rtf", 
                Title = "Import Note"
            };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Note importedNote = new Note();

                try
                {
                
                    RichTextBox tempRtb = new RichTextBox();

                 
                    tempRtb.LoadFile(openFile.FileName, RichTextBoxStreamType.RichText);

                    string? rtfContent = tempRtb.Rtf;

                    string rawText = tempRtb.Text;
                    var lines = rawText.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries); // ��� '\r' ������� �� ������ ������ ��������

                    string? title = lines.FirstOrDefault(l => l.StartsWith("Title:", StringComparison.OrdinalIgnoreCase))?.Replace("Title:", "", StringComparison.OrdinalIgnoreCase).Trim();
                    string? category = lines.FirstOrDefault(l => l.StartsWith("Category:", StringComparison.OrdinalIgnoreCase))?.Replace("Category:", "", StringComparison.OrdinalIgnoreCase).Trim();
                    string? dateStr = lines.FirstOrDefault(l => l.StartsWith("Created On:", StringComparison.OrdinalIgnoreCase))?.Replace("Created On:", "", StringComparison.OrdinalIgnoreCase).Trim();
                    string? RemiStr = lines.FirstOrDefault(l => l.StartsWith("Reminder On:", StringComparison.OrdinalIgnoreCase))?.Replace("Reminder On:", "", StringComparison.OrdinalIgnoreCase).Trim();

                    DateTime creationDate;
                    if (!DateTime.TryParse(dateStr, out creationDate))
                    {
                        creationDate = DateTime.Now; 
                    }

                    DateTime reminderDate;
                    if (!DateTime.TryParse(RemiStr, out reminderDate))
                    {
                        reminderDate = DateTime.Now;
                    }

                    UserController userController = new UserController();
                    int currentUserId = 1; 
                    User? currentUser = userController.GetUserById(currentUserId);
                    if (currentUser == null)
                    {
                        MessageBox.Show("Could not find the current user. Please ensure a user is logged in.", "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                  
                    importedNote.Title = title ?? Path.GetFileNameWithoutExtension(openFile.FileName);

                    if (!Enum.TryParse(typeof(Category), category, true, out var parsedCategory) || !(parsedCategory is Category validCategory))
                    {
                      
                        MessageBox.Show($"Invalid category '{category}' found in file. Defaulting to 'Uncategorized'.", "Import Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        importedNote.Category = Category.Uncategorized;
                    }
                    else
                    {
                        importedNote.Category = validCategory;
                    }

                    importedNote.CreationDate = creationDate;
                    importedNote.ReminderDate = reminderDate;
                    importedNote.Content = rtfContent; 
                    importedNote.UserID = currentUser.UserID;

                 
                    SaveNoteToDatabase(importedNote);


                    Note_Form noteForm = new Note_Form();
                    noteForm.richTextBox1.Rtf = rtfContent;
                    noteForm.Show();

                    MessageBox.Show("Note imported and saved successfully!", "Import Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error importing the file: " + (ex.InnerException?.Message ?? ex.Message),
                        "Import Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void SaveNoteToDatabase(Note note)
        {
            using (var context = new ManageNoteContext())
            {
                context.Notes.Add(note);
                context.SaveChanges();
            }
        }

    }
}
