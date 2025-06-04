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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewNotes));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            detailView = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            Notes_Grid = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            colCreationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colReminderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            DeleteColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            BtnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            Pn_Container = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            openToolStripMenuItem = new ToolStripMenuItem();
            deleteAllSeToolStripMenuItem = new ToolStripMenuItem();
            saveInYourDeviceToolStripMenuItem = new ToolStripMenuItem();
            liveTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)detailView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Notes_Grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnDelete).BeginInit();
            Pn_Container.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // detailView
            // 
            detailView.ColumnPanelRowHeight = 60;
            detailView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1 });
            detailView.GridControl = Notes_Grid;
            detailView.Name = "detailView";
            detailView.RowHeight = 50;
            // 
            // gridColumn1
            // 
            gridColumn1.AppearanceCell.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gridColumn1.AppearanceCell.Options.UseFont = true;
            gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridColumn1.AppearanceHeader.BackColor = Color.FromArgb(222, 233, 239);
            gridColumn1.AppearanceHeader.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gridColumn1.AppearanceHeader.Options.UseBackColor = true;
            gridColumn1.AppearanceHeader.Options.UseFont = true;
            gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridColumn1.Caption = "Content";
            gridColumn1.FieldName = "Content";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            // 
            // Notes_Grid
            // 
            Notes_Grid.DataSource = typeof(Models.Note);
            Notes_Grid.Dock = DockStyle.Fill;
            gridLevelNode1.LevelTemplate = detailView;
            gridLevelNode1.RelationName = "detailView";
            Notes_Grid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] { gridLevelNode1 });
            Notes_Grid.Location = new Point(0, 0);
            Notes_Grid.MainView = gridView1;
            Notes_Grid.Name = "Notes_Grid";
            Notes_Grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { BtnDelete });
            Notes_Grid.Size = new Size(915, 565);
            Notes_Grid.TabIndex = 0;
            Notes_Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1, detailView });
            Notes_Grid.Layout += Notes_Grid_Layout;
            // 
            // gridView1
            // 
            gridView1.Appearance.Empty.BackColor = Color.FromArgb(222, 233, 239);
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
            gridView1.Appearance.SelectedRow.ForeColor = Color.Black;
            gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            gridView1.ColumnPanelRowHeight = 75;
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colTitle, colCreationDate, colReminderDate, colCategory, DeleteColumn, gridColumn2 });
            gridView1.GridControl = Notes_Grid;
            gridView1.Name = "gridView1";
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView1.OptionsSelection.EnableAppearanceFocusedRow = false;
            gridView1.OptionsSelection.EnableAppearanceHideSelection = false;
            gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            gridView1.RowHeight = 50;
            gridView1.RowStyle += gridView1_RowStyle;
            gridView1.PopupMenuShowing += gridView1_PopupMenuShowing;
            gridView1.CellValueChanged += gridView1_CellValueChanged;
            gridView1.RowUpdated += gridView1_RowUpdated;
            gridView1.CustomUnboundColumnData += gridView1_CustomUnboundColumnData;
            gridView1.CustomColumnDisplayText += gridView1_CustomColumnDisplayText;
            // 
            // colTitle
            // 
            colTitle.AppearanceCell.Font = new Font("Tahoma", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colTitle.AppearanceCell.Options.UseFont = true;
            colTitle.AppearanceCell.Options.UseTextOptions = true;
            colTitle.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colTitle.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colTitle.AppearanceHeader.BackColor = Color.FromArgb(222, 233, 239);
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
            colTitle.Width = 145;
            // 
            // colCreationDate
            // 
            colCreationDate.AppearanceCell.Font = new Font("Tahoma", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colCreationDate.AppearanceCell.Options.UseFont = true;
            colCreationDate.AppearanceCell.Options.UseTextOptions = true;
            colCreationDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colCreationDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colCreationDate.AppearanceHeader.BackColor = Color.FromArgb(222, 233, 239);
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
            colCreationDate.Width = 145;
            // 
            // colReminderDate
            // 
            colReminderDate.AppearanceCell.Font = new Font("Tahoma", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colReminderDate.AppearanceCell.Options.UseFont = true;
            colReminderDate.AppearanceCell.Options.UseTextOptions = true;
            colReminderDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colReminderDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colReminderDate.AppearanceHeader.BackColor = Color.FromArgb(222, 233, 239);
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
            colReminderDate.Width = 177;
            // 
            // colCategory
            // 
            colCategory.AppearanceCell.Font = new Font("Tahoma", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colCategory.AppearanceCell.Options.UseFont = true;
            colCategory.AppearanceCell.Options.UseTextOptions = true;
            colCategory.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colCategory.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colCategory.AppearanceHeader.BackColor = Color.FromArgb(222, 233, 239);
            colCategory.AppearanceHeader.Font = new Font("Tahoma", 20.25F, FontStyle.Bold);
            colCategory.AppearanceHeader.ForeColor = Color.Black;
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
            colCategory.Width = 145;
            // 
            // DeleteColumn
            // 
            DeleteColumn.AppearanceCell.BackColor = Color.White;
            DeleteColumn.AppearanceCell.ForeColor = Color.Black;
            DeleteColumn.AppearanceCell.Options.UseBackColor = true;
            DeleteColumn.AppearanceCell.Options.UseForeColor = true;
            DeleteColumn.AppearanceCell.Options.UseTextOptions = true;
            DeleteColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            DeleteColumn.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            DeleteColumn.AppearanceHeader.BackColor = Color.FromArgb(222, 233, 239);
            DeleteColumn.AppearanceHeader.Options.UseBackColor = true;
            DeleteColumn.AppearanceHeader.Options.UseTextOptions = true;
            DeleteColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            DeleteColumn.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            DeleteColumn.ColumnEdit = BtnDelete;
            DeleteColumn.MaxWidth = 75;
            DeleteColumn.Name = "DeleteColumn";
            DeleteColumn.Visible = true;
            DeleteColumn.VisibleIndex = 6;
            // 
            // BtnDelete
            // 
            BtnDelete.AutoHeight = false;
            editorButtonImageOptions1.Image = (Image)resources.GetObject("editorButtonImageOptions1.Image");
            BtnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            BtnDelete.Name = "BtnDelete";
            BtnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridColumn2
            // 
            gridColumn2.AppearanceCell.Font = new Font("Tahoma", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gridColumn2.AppearanceCell.Options.UseFont = true;
            gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridColumn2.AppearanceHeader.BackColor = Color.FromArgb(222, 233, 239);
            gridColumn2.AppearanceHeader.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gridColumn2.AppearanceHeader.Options.UseBackColor = true;
            gridColumn2.AppearanceHeader.Options.UseFont = true;
            gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridColumn2.Caption = "Timer";
            gridColumn2.FieldName = "TimeDiff";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.UnboundDataType = typeof(string);
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 5;
            gridColumn2.Width = 88;
            // 
            // Pn_Container
            // 
            Pn_Container.Controls.Add(Notes_Grid);
            Pn_Container.Dock = DockStyle.Fill;
            Pn_Container.Location = new Point(0, 0);
            Pn_Container.Name = "Pn_Container";
            Pn_Container.Size = new Size(915, 565);
            Pn_Container.TabIndex = 0;
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
            // liveTimer
            // 
            liveTimer.Enabled = true;
            liveTimer.Interval = 1000;
            liveTimer.Tick += liveTimer_Tick;
            // 
            // ViewNotes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 46);
            ClientSize = new Size(915, 565);
            Controls.Add(Pn_Container);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewNotes";
            Text = "View Notes";
            ((System.ComponentModel.ISupportInitialize)detailView).EndInit();
            ((System.ComponentModel.ISupportInitialize)Notes_Grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnDelete).EndInit();
            Pn_Container.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Panel Pn_Container;
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
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.Timer liveTimer;
        private DevExpress.XtraGrid.Views.Grid.GridView detailView;
    }
}