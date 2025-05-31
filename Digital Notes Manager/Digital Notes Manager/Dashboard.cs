using DevExpress.XtraBars.Ribbon;
using Digital_Notes_Manager.Controller;
using Digital_Notes_Manager.Models;
using System.Data;
using System.Drawing.Drawing2D;
using DevExpress.XtraEditors;


namespace Digital_Notes_Manager
{


    public partial class Dashboard : RibbonForm
    {
        private List<Note_Form> noteForms = new List<Note_Form>();
        private int currentIndex = 0;
        private int notesToShow = 2;  // عدد النوتس اللي تظهر في الكروزال في نفس الوقت
        private int noteWidth = 300;
        private int noteHeight = 180;
        private int margin = 10;


        public Dashboard()
        {
            InitializeComponent();

            LoadingNotes();

            // تعديل مكان الأزرار لتكون تحت النوتس مباشرة
            int buttonsY = 10 + noteHeight + 10; // أعلى النوتس + ارتفاع النوت + مسافة بسيطة
            PreviousBtn.Location = new Point(10, buttonsY);
            NextBtn.Location = new Point(10 + (notesToShow * (noteWidth + margin)) - NextBtn.Width, buttonsY);

            PreviousBtn.BringToFront();
            NextBtn.BringToFront();
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




        private void LoadingNotes()
        {
            NotePanel.Controls.Clear();
            noteForms.Clear();

            UserController user = new UserController();
            var notes = user.GetNotesByUserId(Properties.Settings.Default.UserID);

            foreach (var note in notes)
            {
                var noteForm = new Note_Form
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    ShowInTaskbar = false,
                    Size = new Size(noteWidth, noteHeight)
                };

                InitializeNoteFormWithData(noteForm, note); // نمرر الداتا يدويًا

                NotePanel.Controls.Add(noteForm);
                noteForm.Hide();
                noteForms.Add(noteForm);
            }

            NotePanel.Controls.Add(PreviousBtn);
            NotePanel.Controls.Add(NextBtn);

            ShowNotesInCarousel();
        }


        private void SetNoteData(Note_Form noteForm, Note note)
        {
            // نحاول نمرر البيانات لعنصر الفورم حسب الاسم
            foreach (Control ctrl in noteForm.Controls)
            {
                if (ctrl.Name == "TitleBox" && ctrl is DevExpress.XtraEditors.TextEdit titleBox)
                {
                    titleBox.Text = note.Title;
                }
                else if (ctrl is RichTextBox richBox && ctrl.Name == "richTextBox1")
                {
                    richBox.Text = note.Content;
                }

                // لو عندك عناصر تانية زي Categorybox وهكذا، ممكن تضيفهم هنا بنفس الطريقة
            }
        }

        private void InitializeNoteFormWithData(Note_Form form, Note note)
        {
            form.Tag = note;

            // نفعّل الفورم يدويًا كأن المستخدم بدأ يكتب البيانات
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl.Name == "TitleBox" && ctrl is DevExpress.XtraEditors.TextEdit titleBox)
                {
                    titleBox.Properties.ReadOnly = false;
                    titleBox.Text = note.Title;
                    titleBox.Properties.ReadOnly = true;
                }
                else if (ctrl is RichTextBox richBox && ctrl.Name == "richTextBox1")
                {
                    richBox.Text = note.Content;
                }

                // لو فيه Categorybox مثلاً
                else if (ctrl.Name == "Categorybox" && ctrl is DevExpress.XtraEditors.ComboBoxEdit catBox)
                {
                    catBox.Properties.Items.AddRange(Enum.GetNames(typeof(Category)));

                    if (!string.IsNullOrEmpty(note.Category.ToString()))
                    {
                        catBox.SelectedItem = note.Category.ToString();
                    }
                }
            }
        }



        private void ShowNotesInCarousel()
        {
            // أخفي جميع النوتس في البداية
            NotePanel.Controls.Cast<Control>().Where(c => !(c is DevExpress.XtraEditors.SimpleButton)).ToList().ForEach(c => c.Hide());

            int x = 10, y = 10;

            for (int i = 0; i < notesToShow; i++)
            {
                int noteIndex = currentIndex + i;
                if (noteIndex >= noteForms.Count) break;

                var noteForm = noteForms[noteIndex];
                noteForm.Location = new Point(x + i * (noteWidth + margin), y);
                noteForm.Show();
            }
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
