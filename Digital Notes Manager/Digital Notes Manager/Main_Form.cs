using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using Digital_Notes_Manager.Models;
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

    }
}
