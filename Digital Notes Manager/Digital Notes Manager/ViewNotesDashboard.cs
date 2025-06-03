using Digital_Notes_Manager;
using Digital_Notes_Manager.Customs;
using Digital_Notes_Manager.Models;
using System.Drawing.Drawing2D;

namespace Test
{
    public partial class ViewNotesDashboard : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {

        private ManageNoteContext _dbContext;
        public Category SelectedCategory { get; set; }
        public bool IsCategorySelected { get; set; } = false;
        int _userId = Utilities.GetCurrentLoggedInUserId();
        private bool isSecondColumnVisible = true;
        public ViewNotesDashboard()
        {
            Utilities.ViewNotesDashboard = this;
            InitializeComponent();
            LoadCategories();
            _dbContext = new ManageNoteContext();
            ViewNotesHamubrger viewNotesHamubrger = new ViewNotesHamubrger();
            TableLayoutMDI.Controls.Add(viewNotesHamubrger.Pn_Container, 1, 0);




            //var firstNonEmptyCategory = _dbContext.Notes
            //    .Where(x => x.UserID == _userId)
            //    .GroupBy(x => x.Category)
            //    .Where(g => g.Any())
            //    .OrderByDescending(g => g.Count())
            //    .Select(g => g.Key)
            //    .FirstOrDefault();


            //Get First Category That Has Any Notes
            // If no notes exist, default to Study category
            //if (!Enum.IsDefined(typeof(Category), firstNonEmptyCategory))
            //{
            //    firstNonEmptyCategory = Category.Study;
            //}
            LoadNotesForAllCategories("");
        }

        public static readonly Dictionary<Category, Color> CategoryColors = new Dictionary<Category, Color>
        {
            { Category.None, Color.FromArgb(44, 62, 80)},      // Light Blue
            { Category.Study, Color.FromArgb(59, 76, 57) },      // Light Blue
            { Category.Work, ColorTranslator.FromHtml("#505050") },       // Light Yellow
            { Category.Ideas,  ColorTranslator.FromHtml("#6f5a40") },      // Light Green
            { Category.Reminders, ColorTranslator.FromHtml("#2A3C6A") },  // Beige
            { Category.Personal, ColorTranslator.FromHtml("#406f48")},  // Light Blue-Gray
        };


        private void LoadCategories()
        {
            CategoryPanel.Controls.Clear();
            //Adding A new Floylayout Panel in Run Time
            FlowLayoutPanel CategoryflowLayoutPanel = new FlowLayoutPanel()
            {
                Dock = DockStyle.Fill,
                AutoScroll = false,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true,
                Padding = new Padding(10),
            };
            CategoryPanel.Controls.Add(CategoryflowLayoutPanel);

            //Creating A New Card For Each Category
            try
            {
                _dbContext = new ManageNoteContext();
                Panel cardCategoryAll = CreateCategoryCard("All Categories");
                CategoryflowLayoutPanel.Controls.Add(cardCategoryAll);
                foreach (var category in Enum.GetNames(typeof(Category)))
                {
                    if (category != "None")
                    {
                        Panel card = CreateCategoryCard(category);
                        CategoryflowLayoutPanel.Controls.Add(card);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error on load Categories: {ex.Message}");
            }
        }

        // 2 events => all categories click & specfic category click
        private Panel CreateCategoryCard(string category)
        {
            RoundedPanel card = new RoundedPanel
            {
                Size = new Size(200, 100),
                AutoScroll = true,
                Padding = new Padding(10),
                Margin = new Padding(15),
                BorderRadius = 20,
                BorderColor = Color.FromArgb(180, 180, 200),
                BorderThickness = 2
            };

            // Category Title
            Label titleLabel = new Label
            {
                Text = category,
                Font = new Font("Tahoma", 16, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true

            };
            titleLabel.ForeColor = Color.White;
            card.Controls.Add(titleLabel);


            Category parsedCategory;
            if (Enum.TryParse(category, out parsedCategory))
            {
                int noteCount = _dbContext.Notes.Count(n => n.UserID == _userId && n.Category == parsedCategory);

                Label countLabel = new Label
                {
                    Text = $"Notes Count: {noteCount}",
                    ForeColor = Color.White,
                    Font = new Font("Tahoma", 10),
                    Location = new Point(10, 50),
                    AutoSize = true
                };
                card.Controls.Add(countLabel);
                card.BackColor = CategoryColors[parsedCategory];

                //Category Card Click
                card.Click += (s, e) =>
                {
                    IsCategorySelected = true;
                    SelectedCategory = parsedCategory;
                    LoadNotesForSpecficCategory(parsedCategory, card.BackColor, "");
                };
            }
            else
            {
                int noteCount = _dbContext.Notes.Count(n => n.UserID == _userId);

                Label countLabel = new Label
                {
                    Text = $"Notes Count: {noteCount}",
                    ForeColor = Color.White,
                    Font = new Font("Tahoma", 10),
                    Location = new Point(10, 50),
                    AutoSize = true
                };
                card.Controls.Add(countLabel);
                card.BackColor = ColorTranslator.FromHtml("#3d4546");

                card.Click += (s, e) =>
                {
                    IsCategorySelected = false; // Reset the category selection
                    LoadNotesForAllCategories("");
                };
            }
            return card;
        }
        private Panel CreateNoteCard(Note note)
        {
            RoundedPanel card = new RoundedPanel
            {
                Size = new Size(300, 250),
                AutoScroll = true,
                BackColor = Color.FromArgb(245, 245, 255),
                Padding = new Padding(10),
                Margin = new Padding(15),
                BorderRadius = 20,
                BorderColor = Color.FromArgb(180, 180, 200),
                BorderThickness = 1
            };
            Note_Form noteForm = new Note_Form(note);
            return noteForm.Container;
        }
        private string ConvertRtfToPlainText(string rtfText)
        {
            using (var richTextBox = new System.Windows.Forms.RichTextBox())
            {
                richTextBox.Rtf = rtfText;
                return richTextBox.Text;
            }
        }

        public void LoadNotesForSpecficCategory(Category category, Color c, string searchFor)
        {
            var notesFromDb = _dbContext.Notes
                .Where(n => n.UserID == _userId && n.Category == category)
                .OrderByDescending(x => x.CreationDate)
                .ToList();

            List<Note> filteredNotes;

            if (string.IsNullOrWhiteSpace(searchFor))
            {
                filteredNotes = notesFromDb;
            }
            else
            {
                filteredNotes = notesFromDb
                    .Where(n => ConvertRtfToPlainText(n.Content).Contains(searchFor))
                    .ToList();
            }

            //if (notes.Count == 0)
            //{
            //    MessageBox.Show("You Have No Notes For This Category !!!");
            //    return;
            //}

            notesPanel.Controls.Clear();
            foreach (var note in filteredNotes)
            {
                Note_Form noteForm = new Note_Form(note);
                noteForm.TopPanal.BackColor = c; // Set the background color of the note card
                noteForm.TitleBox.BackColor = c;
                noteForm.Container.Dock = DockStyle.None;
                notesPanel.Controls.Add(noteForm.Container);
            }
        }
        public void LoadNotesForAllCategories(string searchFor)
        {
            var notesFromDb = _dbContext.Notes
                .Where(n => n.UserID == _userId)
                .OrderByDescending(x => x.CreationDate)
                .ToList();

            List<Note> filteredNotes;

            if (string.IsNullOrWhiteSpace(searchFor))
            {
                filteredNotes = notesFromDb;
            }
            else
            {
                filteredNotes = notesFromDb
                    .Where(n => ConvertRtfToPlainText(n.Content).Contains(searchFor))
                    .ToList();
            }
            //if (notes.Count == 0)
            //{
            //    MessageBox.Show("You Have No Notes For This Category !!!");
            //    return;
            //}

            notesPanel.Controls.Clear();
            foreach (var note in filteredNotes)
            {
                Note_Form noteForm = new Note_Form(note);
                noteForm.noteId = note.ID;

                Color c = CategoryColors.ContainsKey(note.Category) ? CategoryColors[note.Category] : Color.Pink;
                noteForm.TopPanal.BackColor = c;
                noteForm.TitleBox.BackColor = c;
                noteForm.Container.Dock = DockStyle.None;
                notesPanel.Controls.Add(noteForm.Container);
            }
        }
        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int r = radius;
            path.AddArc(rect.X, rect.Y, r, r, 180, 90);
            path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
            path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void refreshNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshPoppedOutNotes();
        }

        public void RefreshPoppedOutNotes()
        {
            SearchTextBox.Text = "";
            LoadCategories();
            if (IsCategorySelected == true)
                LoadNotesForSpecficCategory(SelectedCategory, CategoryColors[SelectedCategory], "");
            else
                LoadNotesForAllCategories("");
        }

        private void SerachBox_TextChanged(object sender, EventArgs e)
        {
            if (IsCategorySelected == true)
                LoadNotesForSpecficCategory(SelectedCategory, CategoryColors[SelectedCategory], SearchTextBox.Text);
            else
                LoadNotesForAllCategories(SearchTextBox.Text);

        }

        private void ShoeHideBtn_Click(object sender, EventArgs e)
        {
            int targetColumn = 1;

            if (isSecondColumnVisible)
            {
                // نخفي العمود التاني: نمسح الكنترولات منه ونخفيه
                for (int row = 0; row < TableLayoutMDI.RowCount; row++)
                {
                    var control = TableLayoutMDI.GetControlFromPosition(targetColumn, row);
                    if (control != null)
                    {
                        control.Visible = false;
                    }
                }

                TableLayoutMDI.ColumnStyles[targetColumn].SizeType = SizeType.Absolute;
                TableLayoutMDI.ColumnStyles[targetColumn].Width = 0;
                isSecondColumnVisible = false;
                TableLayoutMDI.ColumnStyles[2].SizeType = SizeType.Absolute;
                TableLayoutMDI.ColumnStyles[2].Width = 50;
                ShoeHideBtn.ImageOptions.Image = Digital_Notes_Manager.Properties.Resources.arrow_button; // Update the icon to show
            }
            else
            {
                for (int row = 0; row < TableLayoutMDI.RowCount; row++)
                {
                    var control = TableLayoutMDI.GetControlFromPosition(targetColumn, row);
                    if (control != null)
                    {
                        control.Visible = true;
                    }
                }

                TableLayoutMDI.ColumnStyles[targetColumn].SizeType = SizeType.Percent;
                TableLayoutMDI.ColumnStyles[targetColumn].Width = 30;
                isSecondColumnVisible = true;
                ShoeHideBtn.ImageOptions.Image = Digital_Notes_Manager.Properties.Resources.right_arrow_solid_square_button; // Update the icon to show

            }
        }
    }
}
