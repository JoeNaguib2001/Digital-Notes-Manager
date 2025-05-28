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
            panel1 = new Panel();
            Notes_Grid = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            colCreationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colReminderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Notes_Grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
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
            Notes_Grid.DataSource = typeof(moduels.Notes);
            Notes_Grid.Dock = DockStyle.Fill;
            Notes_Grid.Location = new Point(0, 0);
            Notes_Grid.MainView = gridView1;
            Notes_Grid.Name = "Notes_Grid";
            Notes_Grid.Size = new Size(915, 565);
            Notes_Grid.TabIndex = 0;
            Notes_Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.ColumnPanelRowHeight = 75;
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colTitle, colCategory, colCreationDate, colReminderDate });
            gridView1.GridControl = Notes_Grid;
            gridView1.Name = "gridView1";
            gridView1.RowHeight = 50;
            gridView1.CellValueChanged += gridView1_CellValueChanged;
            gridView1.RowUpdated += gridView1_RowUpdated;
            // 
            // colTitle
            // 
            colTitle.AppearanceCell.Font = new Font("Tahoma", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colTitle.AppearanceCell.Options.UseFont = true;
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
            colTitle.VisibleIndex = 0;
            // 
            // colCategory
            // 
            colCategory.AppearanceCell.Font = new Font("Tahoma", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colCategory.AppearanceCell.Options.UseFont = true;
            colCategory.AppearanceCell.Options.UseTextOptions = true;
            colCategory.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colCategory.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colCategory.AppearanceHeader.BackColor = Color.FromArgb(46, 49, 56);
            colCategory.AppearanceHeader.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            colCategory.AppearanceHeader.ForeColor = Color.Black;
            colCategory.AppearanceHeader.Options.UseBackColor = true;
            colCategory.AppearanceHeader.Options.UseFont = true;
            colCategory.AppearanceHeader.Options.UseForeColor = true;
            colCategory.AppearanceHeader.Options.UseTextOptions = true;
            colCategory.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colCategory.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            colCategory.FieldName = "Category";
            colCategory.Name = "colCategory";
            colCategory.Visible = true;
            colCategory.VisibleIndex = 1;
            // 
            // colCreationDate
            // 
            colCreationDate.AppearanceCell.Font = new Font("Tahoma", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colCreationDate.AppearanceCell.Options.UseFont = true;
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
            colCreationDate.VisibleIndex = 2;
            // 
            // colReminderDate
            // 
            colReminderDate.AppearanceCell.Font = new Font("Tahoma", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colReminderDate.AppearanceCell.Options.UseFont = true;
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
            colReminderDate.FieldName = "ReminderDate";
            colReminderDate.Name = "colReminderDate";
            colReminderDate.Visible = true;
            colReminderDate.VisibleIndex = 3;
            // 
            // ViewNotes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 565);
            Controls.Add(panel1);
            Name = "ViewNotes";
            Text = "ViewNotes";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Notes_Grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
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
    }
}