using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using Digital_Notes_Manager.moduels;

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
                        // Logic to add a new note
                        XtraMessageBox.Show("Add a new note functionality is not implemented yet.");
                        break;

                    default:
                        XtraMessageBox.Show("Unknown action.");
                        break;
                }

            }
        }

        ViewNotes viewNotes;
        ManageNoteContext manageNoteContext;

        private void LoadNotesForm()
        {
            this.MDI_Panel.Controls.Clear();
            SetDataSource();
            MDI_Panel.Controls.Add(viewNotes.panel1);
        }
        public void SetDataSource()
        {
            manageNoteContext = new ManageNoteContext();
            viewNotes = new ViewNotes(manageNoteContext, this);
            var list = manageNoteContext.Notes.ToList();
            //BindingList<Note> BLN = new BindingList<Note>(list);
            // viewNotes.Notes_Grid.DataSource = BLN;
        }
    }
}
