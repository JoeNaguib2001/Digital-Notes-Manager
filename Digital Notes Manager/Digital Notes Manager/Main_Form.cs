using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using Digital_Notes_Manager.moduels;
using System.ComponentModel;

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
            //this.MDI_Panel.Controls.Clear();
            //manageNoteContext = new ManageNoteContext();
            //viewNotes = new ViewNotes(manageNoteContext);
            //viewNotes.Notes_Grid.DataSource = manageNoteContext.Notes.Local.ToBindingList();

            //// وخد بالك إنك تعمل Load للبيانات قبل كده:
            //manageNoteContext.Notes.Load(); // Requires: using Microsoft.EntityFrameworkCore;
            //MDI_Panel.Controls.Add(viewNotes.panel1);
            this.MDI_Panel.Controls.Clear();
            manageNoteContext = new ManageNoteContext();
            Testing testing = new Testing(manageNoteContext);
            var list = manageNoteContext.Notes.ToList();
            BindingList<Notes> bindingList = new BindingList<Notes>(list);
            testing.gridControl1.DataSource = bindingList;
            this.MDI_Panel.Controls.Add(testing.panel1);
        }
    }
}
