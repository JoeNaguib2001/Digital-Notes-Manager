using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using Digital_Notes_Manager.AlarmSystem;
using Digital_Notes_Manager.Models;
using System.ComponentModel;

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
        ManageNoteContext manageNoteContext = new ManageNoteContext();

        private void LoadNotesForm()
        {
            this.MDI_Panel.Controls.Clear();
            viewNotes = new ViewNotes(manageNoteContext, this);
            SetDataSource(viewNotes.Notes_Grid);
            MDI_Panel.Controls.Add(viewNotes.panel1);
            var resources = typeof(Program).Assembly.GetManifestResourceNames();
            foreach (var res in resources)
            {
                System.Diagnostics.Debug.WriteLine(res);
            }
        }
        public void SetDataSource(GridControl GC)
        {
            manageNoteContext = new ManageNoteContext();
            var list = manageNoteContext.Notes.ToList();
            BindingList<Note> BLN = new BindingList<Note>(list);
            GC.DataSource = BLN;
        }
    
        public void IsMached(Note note) {
            this.Invoke((MethodInvoker)(() =>
            {
                alertControl.Show(null, "⏰ Reminder", $"🔔 {note.Title} is due now!");
            }));
        }
        public void ShowSoonMessage(Note note)
        {
            this.Invoke((MethodInvoker)(() =>
            {
                alertControl.Show(null, "⏰ Reminder",$"Note {note.Title} is coming soon!");
            }));
        }
        private async void Notify_Load(object sender, EventArgs e)
        {
            List<Note> list = manageNoteContext.Users
                .SelectMany(us => us.Notes)
                .ToList(); 
            Alarm alarm = new Alarm(this, list);
            _=alarm.CompareTimeAsync(); 
        }
    

    }
}
