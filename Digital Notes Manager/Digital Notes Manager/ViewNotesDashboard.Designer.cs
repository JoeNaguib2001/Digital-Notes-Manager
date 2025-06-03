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
            TableLayoutMDI = new Panel();
            TableLayoutMDIInsider = new TableLayoutPanel();
            CategoryPanel = new Panel();
            label2 = new Label();
            label3 = new Label();
            notesPanel = new FlowLayoutPanel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            refreshNotesToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            SearchTextBox = new TextBox();
            fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(components);
            fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            fluentDesignFormContainer1.SuspendLayout();
            TableLayoutMDI.SuspendLayout();
            TableLayoutMDIInsider.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fluentFormDefaultManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).BeginInit();
            SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            fluentDesignFormContainer1.Controls.Add(TableLayoutMDI);
            fluentDesignFormContainer1.Dock = DockStyle.Fill;
            fluentDesignFormContainer1.Location = new Point(0, 31);
            fluentDesignFormContainer1.Margin = new Padding(3, 2, 3, 2);
            fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            fluentDesignFormContainer1.Size = new Size(1029, 619);
            fluentDesignFormContainer1.TabIndex = 0;
            // 
            // TableLayoutMDI
            // 
            TableLayoutMDI.Controls.Add(TableLayoutMDIInsider);
            TableLayoutMDI.Controls.Add(tableLayoutPanel1);
            TableLayoutMDI.Dock = DockStyle.Fill;
            TableLayoutMDI.Location = new Point(0, 0);
            TableLayoutMDI.Name = "TableLayoutMDI";
            TableLayoutMDI.Size = new Size(1029, 619);
            TableLayoutMDI.TabIndex = 0;
            // 
            // TableLayoutMDIInsider
            // 
            TableLayoutMDIInsider.ColumnCount = 1;
            TableLayoutMDIInsider.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutMDIInsider.Controls.Add(CategoryPanel, 0, 1);
            TableLayoutMDIInsider.Controls.Add(label2, 0, 2);
            TableLayoutMDIInsider.Controls.Add(label3, 0, 0);
            TableLayoutMDIInsider.Controls.Add(notesPanel, 0, 3);
            TableLayoutMDIInsider.Dock = DockStyle.Fill;
            TableLayoutMDIInsider.Location = new Point(0, 46);
            TableLayoutMDIInsider.Margin = new Padding(3, 2, 3, 2);
            TableLayoutMDIInsider.Name = "TableLayoutMDIInsider";
            TableLayoutMDIInsider.RowCount = 4;
            TableLayoutMDIInsider.RowStyles.Add(new RowStyle(SizeType.Percent, 5.5462966F));
            TableLayoutMDIInsider.RowStyles.Add(new RowStyle(SizeType.Percent, 22.1851864F));
            TableLayoutMDIInsider.RowStyles.Add(new RowStyle(SizeType.Percent, 5.546298F));
            TableLayoutMDIInsider.RowStyles.Add(new RowStyle(SizeType.Percent, 66.72222F));
            TableLayoutMDIInsider.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutMDIInsider.Size = new Size(1029, 573);
            TableLayoutMDIInsider.TabIndex = 1;
            // 
            // CategoryPanel
            // 
            CategoryPanel.AutoScroll = true;
            CategoryPanel.BackColor = Color.FromArgb(222, 233, 239);
            CategoryPanel.Dock = DockStyle.Fill;
            CategoryPanel.Location = new Point(3, 33);
            CategoryPanel.Margin = new Padding(3, 2, 3, 2);
            CategoryPanel.Name = "CategoryPanel";
            CategoryPanel.Size = new Size(1023, 123);
            CategoryPanel.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(53, 150, 181);
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 158);
            label2.Name = "label2";
            label2.Padding = new Padding(10, 5, 10, 10);
            label2.Size = new Size(1023, 31);
            label2.TabIndex = 1;
            label2.Text = "Notes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(53, 150, 181);
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(10, 5, 5, 5);
            label3.Size = new Size(1023, 31);
            label3.TabIndex = 3;
            label3.Text = "Categories";
            // 
            // notesPanel
            // 
            notesPanel.AutoScroll = true;
            notesPanel.BackColor = Color.FromArgb(222, 233, 239);
            notesPanel.ContextMenuStrip = contextMenuStrip1;
            notesPanel.Dock = DockStyle.Fill;
            notesPanel.Location = new Point(3, 192);
            notesPanel.Name = "notesPanel";
            notesPanel.Padding = new Padding(10);
            notesPanel.Size = new Size(1023, 378);
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(SearchTextBox, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1029, 46);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // SearchTextBox
            // 
            SearchTextBox.BackColor = Color.FromArgb(53, 150, 181);
            SearchTextBox.Dock = DockStyle.Fill;
            SearchTextBox.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchTextBox.Location = new Point(8, 8);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(503, 33);
            SearchTextBox.TabIndex = 0;
            SearchTextBox.TextChanged += SerachBox_TextChanged;
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
            fluentDesignFormControl1.Size = new Size(1029, 31);
            fluentDesignFormControl1.TabIndex = 4;
            fluentDesignFormControl1.TabStop = false;
            fluentDesignFormControl1.Text = "View All Notes";
            // 
            // ViewNotesDashboard
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 650);
            ControlContainer = fluentDesignFormContainer1;
            Controls.Add(fluentDesignFormContainer1);
            Controls.Add(fluentDesignFormControl1);
            FluentDesignFormControl = fluentDesignFormControl1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ViewNotesDashboard";
            Text = "View All Notes";
            fluentDesignFormContainer1.ResumeLayout(false);
            TableLayoutMDI.ResumeLayout(false);
            TableLayoutMDIInsider.ResumeLayout(false);
            TableLayoutMDIInsider.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fluentFormDefaultManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel CategoryPanel;
        private System.Windows.Forms.Label label3;
        public TableLayoutPanel TableLayoutMDIInsider;
        private FlowLayoutPanel notesPanel;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem refreshNotesToolStripMenuItem;
        private TextBox SearchTextBox;
        private TableLayoutPanel tableLayoutPanel1;
        public Panel TableLayoutMDI;
    }
}

