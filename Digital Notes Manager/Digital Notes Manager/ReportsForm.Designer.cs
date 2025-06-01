namespace Digital_Notes_Manager
{
    partial class ReportsForm
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
            chartControlCategory = new DevExpress.XtraCharts.ChartControl();
            chartControlReminder = new DevExpress.XtraCharts.ChartControl();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)chartControlCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartControlReminder).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // chartControlCategory
            // 
            chartControlCategory.Location = new Point(3, 221);
            chartControlCategory.Name = "chartControlCategory";
            chartControlCategory.Size = new Size(770, 213);
            chartControlCategory.TabIndex = 0;
            // 
            // chartControlReminder
            // 
            chartControlReminder.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            chartControlReminder.Location = new Point(3, 3);
            chartControlReminder.Name = "chartControlReminder";
            chartControlReminder.Size = new Size(770, 212);
            chartControlReminder.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(chartControlCategory, 0, 1);
            tableLayoutPanel1.Controls.Add(chartControlReminder, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(776, 437);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "ReportsForm";
            Text = "ReportsForm";
            ((System.ComponentModel.ISupportInitialize)chartControlCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartControlReminder).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControlCategory;
        private DevExpress.XtraCharts.ChartControl chartControlReminder;
        private TableLayoutPanel tableLayoutPanel1;
    }
}