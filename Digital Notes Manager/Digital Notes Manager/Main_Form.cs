
using DevExpress.XtraBars.Navigation;

namespace Digital_Notes_Manager
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            View_My_Notes_Accordion_Element.Click += Accordion_Element_Click;
            Add_New_Note_Accordion_Element.Click += Accordion_Element_Click;
        }

        private void Accordion_Element_Click(object? sender, EventArgs e)
        {
            AccordionControlElement? element = sender as AccordionControlElement;
            if (element != null)
            {
                switch (element.Name)
                {
                    case "View_My_Notes_Accordion_Element":
                        Notes_Grid notesGrid = new Notes_Grid();
                        notesGrid.Show();
                        break;
                    case "Add_New_Note_Accordion_Element":
                        // Logic to add a new note can be implemented here
                        MessageBox.Show("Add New Note functionality is not yet implemented.");
                        break;
                    default:
                        MessageBox.Show("Unknown action.");
                        break;
                }
            }
        }
    }
}
