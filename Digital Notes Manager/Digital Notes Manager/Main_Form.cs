using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using Digital_Notes_Manager.AlarmSystem;
using Digital_Notes_Manager.Models;


namespace Digital_Notes_Manager
{
    public partial class Main_Form : XtraForm
    {
        private DevExpress.XtraBars.Alerter.AlertControl alertControl;

        public Main_Form()
        {
            InitializeComponent();
            this.Shown += Notify_Load;

            Add_A_New_Note_Accordion_Element.Click += AccordionElementClick;
            Show_Notes_Accordion_Element.Click += AccordionElementClick;
            alertControl = new DevExpress.XtraBars.Alerter.AlertControl();

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
            var resources = typeof(Program).Assembly.GetManifestResourceNames();
            foreach (var res in resources)
            {
                System.Diagnostics.Debug.WriteLine(res);
            }
        }




        private void View_All_Notes_Popped_Click(object sender, EventArgs e)
        {
            //var list = manageNoteContext.Notes.ToList();
            //for (int i = 0; i < 5; i++)
            //{
            //    Note_Form note_form = new Note_Form();
            //    note_form.richTextBox1.Text = list[i].Content;
            //    note_form.Text = list[i].Title;
            //    note_form.Show();

            //}
            NotesDashboard dashboard = new NotesDashboard();
            this.MDI_Panel.Controls.Clear();
            MDI_Panel.Controls.Add(dashboard.panel1);
        }

        private void importNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Rich Text Files (*rtf)|*.rtf";
            openFile.Title = "Import Notes";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Note_Form note = new Note_Form();


                    note.richTextBox1.LoadFile(openFile.FileName, RichTextBoxStreamType.RichText);
                    string x = note.richTextBox1.Rtf;
                    note.richTextBox1.Rtf = x;
                    note.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error importing the file: " + ex.Message, "Import Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void IsMached(Note note)
        {
            this.Invoke((MethodInvoker)(() =>
            {
                alertControl.Show(null, "⏰ Reminder", $"🔔 {note.Title} is due now!");
            }));
        }
        public void ShowSoonMessage(Note note)
        {
            this.Invoke((MethodInvoker)(() =>
            {
                alertControl.Show(null, "⏰ Reminder", $"Note {note.Title} is coming soon!");
            }));
        }
        private async void Notify_Load(object sender, EventArgs e)
        {
            int userId = Properties.Settings.Default.UserID;
            List<Note> list = manageNoteContext.Notes
                .Where(x => x.UserID == userId)
                .AsEnumerable()
                .OrderBy(x => x.ReminderDate.UtcDateTime)
                .ToList();
            Alarm alarm = new Alarm(this, list);
            _ = alarm.CompareTimeAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using var context = new ManageNoteContext();
            var reminderDate = new DateTimeOffset(2025, 5, 30, 21, 45, 0, TimeZoneInfo.Local.GetUtcOffset(DateTime.Now));

            var newNote = new Note
            {
                Title = "New Note",
                Content = "This is a new note added manually.",
                Category = Category.Work,
                CreationDate = DateTime.Now,
                ReminderDate = reminderDate,
                UserID = 2 // لازم تتأكد إن اليوزر ده موجود
            };
            //Alarm.AddNewNoteToAlarmSystemNotesList();

            Alarm.AddNewNoteToAlarmSystemNotesList(newNote);
            //context.Notes.Add(newNote);
            //context.SaveChanges();


        }
    }
}
