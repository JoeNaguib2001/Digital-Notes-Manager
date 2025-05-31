using DevExpress.XtraBars.Ribbon;
using Digital_Notes_Manager.Controller;
using Digital_Notes_Manager.Models;
using System.Data;
using System.Drawing.Drawing2D;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Import.Html;

namespace Digital_Notes_Manager
{
    public partial class NotesDashboard : RibbonForm
    {
        private List<Note> Notes = new List<Note>();
        private int noteWidth = 249;
        private int noteHeight = 180;
        private int margin = 10;
        private int cardsPerRow;

        public NotesDashboard()
        {
            InitializeComponent();

            panel1.AutoScroll = true;
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;
            panel1.AutoScrollMinSize = new Size(0, 0);
            panel1.Dock = DockStyle.Fill;


            this.Resize += (s, e) => LoadingNotes();
            panel1.Resize += (s, e) => LoadingNotes();
            // تحميل الملاحظات لمرة واحدة فقط
            UserController user = new UserController();
            Notes = user.GetNotesByUserId(1);

            LoadingNotes();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(Width - radius, Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, Height - radius, radius, radius), 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);
        }

        private void LoadingNotes()
        {
           panel1.Controls.Clear();






            cardsPerRow = Math.Max(1, (panel1.ClientSize.Width - margin) / (noteWidth + margin));

            int x = margin;
            int y = margin;

            for (int i = 0; i < Notes.Count; i++)
            {
                var note = Notes[i];

                var card = new PanelControl
                {
                    Size = new Size(noteWidth, noteHeight),
                    Location = new Point(x, y),
                    BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple,
                    LookAndFeel = { Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat, UseDefaultLookAndFeel = false },
                    Padding = new Padding(5)
                };

                var title = new Label
                {
                    Text = note.Title,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    Location = new Point(10, 10),
                    AutoSize = true
                };

                var category = new Label
                {
                    Text = $"Category: {note.Category}",
                    Font = new Font("Segoe UI", 10, FontStyle.Italic),
                    Location = new Point(10, 40),
                    AutoSize = true
                };

                var preview = new Label
                {
                    Text = note.Content.Length > 100 ? note.Content.Substring(0, 100) + "..." : note.Content,
                    Font = new Font("Segoe UI", 9),
                    Location = new Point(10, 70),
                    Size = new Size(noteWidth - 20, 60),
                    AutoEllipsis = true
                };

                // إضافة الأحداث لعرض التفاصيل
                EventHandler clickHandler = (s, e) => ShowNoteDetails(note);
                card.Click += clickHandler;
                title.Click += clickHandler;
                category.Click += clickHandler;
                preview.Click += clickHandler;

                card.Controls.Add(title);
                card.Controls.Add(category);
                card.Controls.Add(preview);
                panel1.Controls.Add(card);

                if ((panel1.Controls.Count % cardsPerRow) == 0)
                {
                    x = margin;
                    y += noteHeight + margin;
                }
                else
                {
                    x += noteWidth + margin;
                }
            }
        }

        private void ShowNoteDetails(Note note)
        {
            Note_Form noteForm = new Note_Form(note);

            panel1.Controls.Clear();

            noteForm.TopLevel = false;  
            noteForm.FormBorderStyle = FormBorderStyle.None;
            noteForm.Dock = DockStyle.Fill;

            panel1.Controls.Add(noteForm);
            noteForm.Show();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
