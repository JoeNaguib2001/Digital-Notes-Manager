using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using Digital_Notes_Manager.AlarmSystem;
using Digital_Notes_Manager.Models;
using Test;


namespace Digital_Notes_Manager
{
    public partial class Main_Form : XtraForm
    {
        private DevExpress.XtraBars.Alerter.AlertControl alertControl;
        public ViewNotes viewNotes;
        ManageNoteContext manageNoteContext = Utilities.manageNoteContext;
        public Main_Form()
        {
            InitializeComponent();
            this.Shown += Notify_Load;

            Add_A_New_Note_Accordion_Element.Click += AccordionElementClick;
            Show_Notes_Accordion_Element.Click += AccordionElementClick;
            View_All_Notes_Popped.Click += AccordionElementClick;
            Logout_AccordionElement.Click += AccordionElementClick;
            Report_ControlElement.Click += AccordionElementClick;
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
                    case "View_All_Notes_Popped":
                        {
                            LoadAllNotesPoppedOut();
                        }
                        break;
                    case "Logout_AccordionElement":
                        {
                            Logout();
                        }
                        break;
                    case "Report_ControlElement":
                        {
                            LoadReportsForm();
                        }
                        break;
                    default:
                        XtraMessageBox.Show("Unknown action.");
                        break;
                }
            }
        }




        private void LoadNotesForm()
        {
            this.MDI_Panel.Controls.Clear();
            viewNotes = new ViewNotes();
            MDI_Panel.Controls.Add(viewNotes.Pn_Container);
            var resources = typeof(Program).Assembly.GetManifestResourceNames();
            foreach (var res in resources)
            {
                System.Diagnostics.Debug.WriteLine(res);
            }
        }

        private void Logout()
        {
            this.Hide();
            Utilities.LoginRegisterMDI.Show();
            Utilities.LoginRegisterMDI.LoadLogin();
            Properties.Settings.Default.userID = 0;
            Properties.Settings.Default.userName = string.Empty;
            Properties.Settings.Default.rememberMe = false;
            Properties.Settings.Default.Save();

        }

        private void LoadAllNotesPoppedOut()
        {
            MDI_Panel.Controls.Clear();
            ViewNotesDashboard viewNotesDashboard = new ViewNotesDashboard();
            MDI_Panel.Controls.Add(viewNotesDashboard.TableLayoutMDI);
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
            int userId = Properties.Settings.Default.userID;
            List<Note> list = manageNoteContext.Notes
                .Where(x => x.UserID == userId)
                .AsEnumerable()
                .OrderBy(x => x.ReminderDate)
                .ToList();
            Alarm alarm = new Alarm(this, list);
            _ = alarm.CompareTimeAsync();
        }

        private void LoadReportsForm()
        {
            int userId = Properties.Settings.Default.userID;
            var notes = manageNoteContext.Notes
                .Where(n => n.UserID == userId)
                .ToList();

            ReportsForm reportsForm = new ReportsForm(notes);
            MDI_Panel.Controls.Clear();
            MDI_Panel.Controls.Add(reportsForm.tableLayoutPanel1);
        }

        private void LogoutAccordionElement_Click(object sender, EventArgs e)
        {
        }

    }
}
