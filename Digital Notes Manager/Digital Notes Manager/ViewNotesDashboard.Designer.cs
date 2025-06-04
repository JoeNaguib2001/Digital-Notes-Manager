namespace Test
{
    partial class ViewNotesDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            TableLayoutMDI = new TableLayoutPanel();
            LeftGreatInsider = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            SearchTextBox = new TextBox();
            CategoriesNotesPanel = new TableLayoutPanel();
            notesPanel = new FlowLayoutPanel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            refreshNotesToolStripMenuItem = new ToolStripMenuItem();
            CategoryPanel = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            ShowHideBtn = new DevExpress.XtraEditors.SimpleButton();
            fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(components);
            fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            fluentDesignFormContainer1.SuspendLayout();
            TableLayoutMDI.SuspendLayout();
            LeftGreatInsider.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            CategoriesNotesPanel.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fluentFormDefaultManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).BeginInit();
            SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            fluentDesignFormContainer1.Controls.Add(TableLayoutMDI);
            fluentDesignFormContainer1.Dock = DockStyle.Fill;
            fluentDesignFormContainer1.Location = new Point(0, 24);
            fluentDesignFormContainer1.Margin = new Padding(3, 2, 3, 2);
            fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            fluentDesignFormContainer1.Size = new Size(1374, 626);
            fluentDesignFormContainer1.TabIndex = 0;
            // 
            // TableLayoutMDI
            // 
            TableLayoutMDI.BackColor = Color.FromArgb(228, 235, 241);
            TableLayoutMDI.ColumnCount = 3;
            TableLayoutMDI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.36487F));
            TableLayoutMDI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.63513F));
            TableLayoutMDI.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            TableLayoutMDI.Controls.Add(LeftGreatInsider, 0, 0);
            TableLayoutMDI.Controls.Add(tableLayoutPanel2, 2, 0);
            TableLayoutMDI.Dock = DockStyle.Fill;
            TableLayoutMDI.Location = new Point(0, 0);
            TableLayoutMDI.Name = "TableLayoutMDI";
            TableLayoutMDI.RowCount = 1;
            TableLayoutMDI.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutMDI.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutMDI.Size = new Size(1374, 626);
            TableLayoutMDI.TabIndex = 1;
            TableLayoutMDI.Resize += TableLayoutMDI_Resize;
            // 
            // LeftGreatInsider
            // 
            LeftGreatInsider.BackColor = Color.White;
            LeftGreatInsider.ColumnCount = 1;
            LeftGreatInsider.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            LeftGreatInsider.Controls.Add(tableLayoutPanel1, 0, 0);
            LeftGreatInsider.Controls.Add(CategoriesNotesPanel, 0, 1);
            LeftGreatInsider.Dock = DockStyle.Fill;
            LeftGreatInsider.Location = new Point(3, 2);
            LeftGreatInsider.Margin = new Padding(3, 2, 3, 2);
            LeftGreatInsider.Name = "LeftGreatInsider";
            LeftGreatInsider.RowCount = 2;
            LeftGreatInsider.RowStyles.Add(new RowStyle());
            LeftGreatInsider.RowStyles.Add(new RowStyle(SizeType.Percent, 100.000008F));
            LeftGreatInsider.Size = new Size(912, 622);
            LeftGreatInsider.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.7940636F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.2059326F));
            tableLayoutPanel1.Controls.Add(SearchTextBox, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(906, 47);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // SearchTextBox
            // 
            SearchTextBox.BackColor = SystemColors.InactiveCaption;
            SearchTextBox.Dock = DockStyle.Fill;
            SearchTextBox.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchTextBox.Location = new Point(8, 8);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(431, 33);
            SearchTextBox.TabIndex = 0;
            SearchTextBox.TextChanged += SerachBox_TextChanged;
            // 
            // CategoriesNotesPanel
            // 
            CategoriesNotesPanel.ColumnCount = 1;
            CategoriesNotesPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            CategoriesNotesPanel.Controls.Add(notesPanel, 0, 1);
            CategoriesNotesPanel.Controls.Add(CategoryPanel, 0, 0);
            CategoriesNotesPanel.Dock = DockStyle.Fill;
            CategoriesNotesPanel.Location = new Point(3, 56);
            CategoriesNotesPanel.Name = "CategoriesNotesPanel";
            CategoriesNotesPanel.RowCount = 2;
            CategoriesNotesPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 270F));
            CategoriesNotesPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            CategoriesNotesPanel.Size = new Size(906, 563);
            CategoriesNotesPanel.TabIndex = 3;
            // 
            // notesPanel
            // 
            notesPanel.AutoScroll = true;
            notesPanel.BackColor = Color.FromArgb(228, 235, 241);
            notesPanel.ContextMenuStrip = contextMenuStrip1;
            notesPanel.Dock = DockStyle.Fill;
            notesPanel.Location = new Point(3, 273);
            notesPanel.Name = "notesPanel";
            notesPanel.Padding = new Padding(10);
            notesPanel.Size = new Size(900, 287);
            notesPanel.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { refreshNotesToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(169, 30);
            // 
            // refreshNotesToolStripMenuItem
            // 
            refreshNotesToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshNotesToolStripMenuItem.Name = "refreshNotesToolStripMenuItem";
            refreshNotesToolStripMenuItem.Size = new Size(168, 26);
            refreshNotesToolStripMenuItem.Text = "refresh notes";
            refreshNotesToolStripMenuItem.Click += refreshNotesToolStripMenuItem_Click;
            // 
            // CategoryPanel
            // 
            CategoryPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CategoryPanel.BackColor = Color.FromArgb(228, 235, 241);
            CategoryPanel.Dock = DockStyle.Fill;
            CategoryPanel.Location = new Point(3, 2);
            CategoryPanel.Margin = new Padding(3, 2, 3, 2);
            CategoryPanel.Name = "CategoryPanel";
            CategoryPanel.Size = new Size(900, 266);
            CategoryPanel.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(ShowHideBtn, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(1326, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 47.36842F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5.263158F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 47.36842F));
            tableLayoutPanel2.Size = new Size(45, 620);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // ShowHideBtn
            // 
            ShowHideBtn.Dock = DockStyle.Fill;
            ShowHideBtn.ImageOptions.Image = Digital_Notes_Manager.Properties.Resources.right_arrow_solid_square_button;
            ShowHideBtn.Location = new Point(3, 296);
            ShowHideBtn.Name = "ShowHideBtn";
            ShowHideBtn.Size = new Size(39, 26);
            ShowHideBtn.TabIndex = 0;
            ShowHideBtn.Click += ShowHideBtn_Click;
            // 
            // fluentFormDefaultManager1
            // 
            fluentFormDefaultManager1.Form = this;
            fluentFormDefaultManager1.MaxItemId = 1;
            // 
            // fluentDesignFormControl1
            // 
            fluentDesignFormControl1.FluentDesignForm = this;
            fluentDesignFormControl1.Location = new Point(0, 0);
            fluentDesignFormControl1.Manager = fluentFormDefaultManager1;
            fluentDesignFormControl1.Margin = new Padding(3, 2, 3, 2);
            fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            fluentDesignFormControl1.Size = new Size(1374, 24);
            fluentDesignFormControl1.TabIndex = 4;
            fluentDesignFormControl1.TabStop = false;
            fluentDesignFormControl1.Text = "View All Notes";
            // 
            // ViewNotesDashboard
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 650);
            ControlContainer = fluentDesignFormContainer1;
            Controls.Add(fluentDesignFormContainer1);
            Controls.Add(fluentDesignFormControl1);
            FluentDesignFormControl = fluentDesignFormControl1;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ViewNotesDashboard";
            Text = "View All Notes";
            fluentDesignFormContainer1.ResumeLayout(false);
            TableLayoutMDI.ResumeLayout(false);
            LeftGreatInsider.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            CategoriesNotesPanel.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fluentFormDefaultManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private System.Windows.Forms.Panel CategoryPanel;
        public TableLayoutPanel LeftGreatInsider;
        private FlowLayoutPanel notesPanel;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem refreshNotesToolStripMenuItem;
        private TextBox SearchTextBox;
        private TableLayoutPanel tableLayoutPanel1;
        public TableLayoutPanel TableLayoutMDI;
        private TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton ShowHideBtn;
        private TableLayoutPanel CategoriesNotesPanel;
    }
}

