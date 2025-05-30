using DevExpress.Utils.Frames;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraRichEdit.Forms;
using Digital_Notes_Manager.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Digital_Notes_Manager.Models;
using DevExpress.DXTemplateGallery.Extensions;


namespace Digital_Notes_Manager
{
    public partial class Dashboard : RibbonForm
    {
        private List<Note_Form> noteForms = new List<Note_Form>();
        private int currentIndex = 0;
        private int notesToShow = 3;  // عدد النوتس اللي تظهر في الكروزال في نفس الوقت
        private int noteWidth = 250;
        private int noteHeight = 150;
        private int margin = 10;
        public Dashboard()
        {
            InitializeComponent();
        }



        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath path = new GraphicsPath();
            int radius = 20; // adjust corner radius
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(Width - radius, Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, Height - radius, radius, radius), 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadingNotes();

        }

        private void LoadingNotes()
        {
            NotePanel.Controls.Clear();
            noteForms.Clear();

            UserController user = new UserController();
            var notes = user.GetNotesByUserId(1);

            foreach (var note in notes)
            {
                var noteForm = new Note_Form
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    ShowInTaskbar = false,
                    Size = new Size(noteWidth, noteHeight),
                    Tag = note
                };

                NotePanel.Controls.Add(noteForm);
                noteForm.Hide(); // نخفيهم الأول
                noteForms.Add(noteForm);
            }

            ShowNotesInCarousel();
        }

        private void ShowNotesInCarousel()
        {
            // خفي فقط النوت فورمز، مش كل الكنترولز داخل NotePanel
            foreach (Control c in NotePanel.Controls)
            {
                if (c is Note_Form)
                    c.Hide();
            }

            int x = 10, y = 10;

            for (int i = 0; i < notesToShow; i++)
            {
                int noteIndex = currentIndex + i;
                if (noteIndex >= noteForms.Count) break;

                var noteForm = noteForms[noteIndex];
                noteForm.Location = new Point(x + i * (noteWidth + margin), y);
                noteForm.Show();
            }
            PreviousBtn.BringToFront();
            NextBtn.BringToFront();


        }



        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (currentIndex + notesToShow < noteForms.Count)
            {
                currentIndex++;
                ShowNotesInCarousel();
            }
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {

            if (currentIndex > 0)
            {
                currentIndex--;
                ShowNotesInCarousel();
            }
         
        }
    }
}
