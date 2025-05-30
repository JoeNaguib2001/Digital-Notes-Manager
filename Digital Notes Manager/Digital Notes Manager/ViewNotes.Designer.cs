namespace Digital_Notes_Manager
{
    partial class ViewNotes
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewNotes));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            panel1 = new Panel();
            Notes_Grid = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            colCreationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colReminderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            DeleteColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            BtnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            contextMenuStrip1 = new ContextMenuStrip(components);
            openToolStripMenuItem = new ToolStripMenuItem();
            deleteAllSeToolStripMenuItem = new ToolStripMenuItem();
            saveInYourDeviceToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Notes_Grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnDelete).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Notes_Grid);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(915, 565);
            panel1.TabIndex = 0;
            // 
            // Notes_Grid
            // 
            Notes_Grid.DataSource = typeof(Models.Note);
            Notes_Grid.Dock = DockStyle.Fill;
            Notes_Grid.Location = new Point(0, 0);
            Notes_Grid.MainView = gridView1;
            Notes_Grid.Name = "Notes_Grid";
            Notes_Grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { BtnDelete });
            Notes_Grid.Size = new Size(915, 565);
            Notes_Grid.TabIndex = 0;
            Notes_Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Appearance.Empty.BackColor = Color.FromArgb(46, 49, 56);
            gridView1.Appearance.Empty.Options.UseBackColor = true;
            gridView1.Appearance.FocusedCell.BackColor = Color.FromArgb(35, 38, 45);
            gridView1.Appearance.FocusedCell.ForeColor = Color.White;
            gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            gridView1.Appearance.FocusedCell.Options.UseForeColor = true;
            gridView1.Appearance.FocusedRow.BackColor = Color.FromArgb(35, 38, 45);
            gridView1.Appearance.FocusedRow.ForeColor = Color.White;
            gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            gridView1.Appearance.HeaderPanel.BackColor = Color.Red;
            gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            gridView1.Appearance.SelectedRow.ForeColor = Color.White;
            gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            gridView1.ColumnPanelRowHeight = 75;
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colTitle, colCreationDate, colReminderDate, colCategory, DeleteColumn });
            gridView1.GridControl = Notes_Grid;
            gridView1.Name = "gridView1";
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView1.OptionsSelection.EnableAppearanceFocusedRow = false;
            gridView1.OptionsSelection.EnableAppearanceHideSelection = false;
            gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            gridView1.RowHeight = 50;
            gridView1.PopupMenuShowing += gridView1_PopupMenuShowing;
            gridView1.CellValueChanged += gridView1_CellValueChanged;
            gridView1.RowUpdated += gridView1_RowUpdated;
            // 
            // colTitle
            // 
            colTitle.AppearanceCell.BackColor = Color.FromArgb(60, 63, 70);
            colTitle.AppearanceCell.Font = new Font("Tahoma", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colTitle.AppearanceCell.ForeColor = Color.White;
            colTitle.AppearanceCell.Options.UseBackColor = true;
            colTitle.AppearanceCell.Options.UseFont = true;
            colTitle.AppearanceCell.Options.UseForeColor = true;
            colTitle.AppearanceCell.Options.UseTextOptions = true;
            colTitle.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colTitle.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colTitle.AppearanceHeader.BackColor = Color.FromArgb(46, 49, 56);
            colTitle.AppearanceHeader.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            colTitle.AppearanceHeader.ForeColor = Color.Black;
            colTitle.AppearanceHeader.Options.UseBackColor = true;
            colTitle.AppearanceHeader.Options.UseFont = true;
            colTitle.AppearanceHeader.Options.UseForeColor = true;
            colTitle.AppearanceHeader.Options.UseTextOptions = true;
            colTitle.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colTitle.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colTitle.FieldName = "Title";
            colTitle.Name = "colTitle";
            colTitle.Visible = true;
            colTitle.VisibleIndex = 1;
            colTitle.Width = 163;
            // 
            // colCreationDate
            // 
            colCreationDate.AppearanceCell.BackColor = Color.FromArgb(60, 63, 70);
            colCreationDate.AppearanceCell.Font = new Font("Tahoma", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colCreationDate.AppearanceCell.ForeColor = Color.White;
            colCreationDate.AppearanceCell.Options.UseBackColor = true;
            colCreationDate.AppearanceCell.Options.UseFont = true;
            colCreationDate.AppearanceCell.Options.UseForeColor = true;
            colCreationDate.AppearanceCell.Options.UseTextOptions = true;
            colCreationDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colCreationDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colCreationDate.AppearanceHeader.BackColor = Color.FromArgb(46, 49, 56);
            colCreationDate.AppearanceHeader.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            colCreationDate.AppearanceHeader.ForeColor = Color.Black;
            colCreationDate.AppearanceHeader.Options.UseBackColor = true;
            colCreationDate.AppearanceHeader.Options.UseFont = true;
            colCreationDate.AppearanceHeader.Options.UseForeColor = true;
            colCreationDate.AppearanceHeader.Options.UseTextOptions = true;
            colCreationDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colCreationDate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colCreationDate.FieldName = "CreationDate";
            colCreationDate.Name = "colCreationDate";
            colCreationDate.Visible = true;
            colCreationDate.VisibleIndex = 3;
            colCreationDate.Width = 163;
            // 
            // colReminderDate
            // 
            colReminderDate.AppearanceCell.BackColor = Color.FromArgb(60, 63, 70);
            colReminderDate.AppearanceCell.Font = new Font("Tahoma", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colReminderDate.AppearanceCell.ForeColor = Color.White;
            colReminderDate.AppearanceCell.Options.UseBackColor = true;
            colReminderDate.AppearanceCell.Options.UseFont = true;
            colReminderDate.AppearanceCell.Options.UseForeColor = true;
            colReminderDate.AppearanceCell.Options.UseTextOptions = true;
            colReminderDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colReminderDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colReminderDate.AppearanceHeader.BackColor = Color.FromArgb(46, 49, 56);
            colReminderDate.AppearanceHeader.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            colReminderDate.AppearanceHeader.ForeColor = Color.Black;
            colReminderDate.AppearanceHeader.Options.UseBackColor = true;
            colReminderDate.AppearanceHeader.Options.UseFont = true;
            colReminderDate.AppearanceHeader.Options.UseForeColor = true;
            colReminderDate.AppearanceHeader.Options.UseTextOptions = true;
            colReminderDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colReminderDate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colReminderDate.DisplayFormat.FormatString = "d";
            colReminderDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            colReminderDate.FieldName = "ReminderDate";
            colReminderDate.Name = "colReminderDate";
            colReminderDate.Visible = true;
            colReminderDate.VisibleIndex = 4;
            colReminderDate.Width = 251;
            // 
            // colCategory
            // 
            colCategory.AppearanceCell.BackColor = Color.FromArgb(60, 63, 70);
            colCategory.AppearanceCell.Font = new Font("Tahoma", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colCategory.AppearanceCell.ForeColor = Color.White;
            colCategory.AppearanceCell.Options.UseBackColor = true;
            colCategory.AppearanceCell.Options.UseFont = true;
            colCategory.AppearanceCell.Options.UseForeColor = true;
            colCategory.AppearanceCell.Options.UseTextOptions = true;
            colCategory.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colCategory.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colCategory.AppearanceHeader.BackColor = Color.FromArgb(46, 49, 56);
            colCategory.AppearanceHeader.Font = new Font("Tahoma", 20.25F, FontStyle.Bold);
            colCategory.AppearanceHeader.ForeColor = Color.White;
            colCategory.AppearanceHeader.Options.UseBackColor = true;
            colCategory.AppearanceHeader.Options.UseFont = true;
            colCategory.AppearanceHeader.Options.UseForeColor = true;
            colCategory.AppearanceHeader.Options.UseTextOptions = true;
            colCategory.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colCategory.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colCategory.Caption = "Category";
            colCategory.FieldName = "Category";
            colCategory.Name = "colCategory";
            colCategory.Visible = true;
            colCategory.VisibleIndex = 2;
            colCategory.Width = 163;
            // 
            // DeleteColumn
            // 
            DeleteColumn.AppearanceCell.BackColor = Color.FromArgb(60, 63, 70);
            DeleteColumn.AppearanceCell.Options.UseBackColor = true;
            DeleteColumn.AppearanceCell.Options.UseTextOptions = true;
            DeleteColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            DeleteColumn.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            DeleteColumn.AppearanceHeader.BackColor = Color.FromArgb(46, 49, 56);
            DeleteColumn.AppearanceHeader.Options.UseBackColor = true;
            DeleteColumn.AppearanceHeader.Options.UseTextOptions = true;
            DeleteColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            DeleteColumn.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            DeleteColumn.ColumnEdit = BtnDelete;
            DeleteColumn.Name = "DeleteColumn";
            DeleteColumn.Visible = true;
            DeleteColumn.VisibleIndex = 5;
            // 
            // BtnDelete
            // 
            BtnDelete.AutoHeight = false;
            editorButtonImageOptions2.Image = (Image)resources.GetObject("editorButtonImageOptions2.Image");
            BtnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            BtnDelete.Name = "BtnDelete";
            BtnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { openToolStripMenuItem, deleteAllSeToolStripMenuItem, saveInYourDeviceToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(176, 70);
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(175, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // deleteAllSeToolStripMenuItem
            // 
            deleteAllSeToolStripMenuItem.Name = "deleteAllSeToolStripMenuItem";
            deleteAllSeToolStripMenuItem.Size = new Size(175, 22);
            deleteAllSeToolStripMenuItem.Text = "Delete";
            deleteAllSeToolStripMenuItem.Click += deleteAllSeToolStripMenuItem_Click;
            // 
            // saveInYourDeviceToolStripMenuItem
            // 
            saveInYourDeviceToolStripMenuItem.Name = "saveInYourDeviceToolStripMenuItem";
            saveInYourDeviceToolStripMenuItem.Size = new Size(175, 22);
            saveInYourDeviceToolStripMenuItem.Text = "Save in your device";
            saveInYourDeviceToolStripMenuItem.Click += saveInYourDeviceToolStripMenuItem_Click;
            // 
            // ViewNotes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 565);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewNotes";
            Text = "View Notes";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Notes_Grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnDelete).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Panel panel1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraGrid.GridControl Notes_Grid;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colCreationDate;
        private DevExpress.XtraGrid.Columns.GridColumn colReminderDate;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteAllSeToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private ToolStripMenuItem openToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn DeleteColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit BtnDelete;
        private ToolStripMenuItem saveInYourDeviceToolStripMenuItem;
    }
}