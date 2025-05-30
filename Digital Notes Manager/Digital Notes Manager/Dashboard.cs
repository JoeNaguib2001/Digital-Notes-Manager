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


namespace Digital_Notes_Manager
{
    public partial class Dashboard : RibbonForm
    {
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

            var user = new UserController();
            var notes = user.GetNotesByUserId(1);

            int x = 10, y = 10;
            int width = 300, height = 180;
            int margin = 10;
            int maxPerRow = 2;
            int col = 0;

            foreach (var note in notes)
            {
                var noteForm = new Note_Form(); // مش هتعدل عليه
                noteForm.TopLevel = false;
                noteForm.FormBorderStyle = FormBorderStyle.None;
                noteForm.ShowInTaskbar = false;
                noteForm.Size = new Size(width, height);
                noteForm.Tag = note;

                noteForm.Load += (s, e) =>
                {
                    var thisNote = noteForm.Tag as Note;
                    if (thisNote != null)
                    {
                        var rtb = noteForm.Controls.OfType<RichTextBox>().FirstOrDefault();
                        if (rtb != null)
                            rtb.Text = thisNote.Content;
                    }
                };

                noteForm.Location = new Point(x + col * (width + margin), y);
                NotePanel.Controls.Add(noteForm);
                noteForm.Show();

                col++;
                if (col == maxPerRow)
                {
                    col = 0;
                    y += height + margin;
                }
            }

            // خلي البانل يقبل Scroll لو النوتات كتير
            NotePanel.AutoScroll = true;
        }


        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
