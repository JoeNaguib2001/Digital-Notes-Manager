using DevExpress.Utils.Frames;

namespace Digital_Notes_Manager
{
    partial class NotesDashboard
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
            CloseBtn = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 749);
            panel1.TabIndex = 0;
            // 
            // CloseBtn
            // 
            CloseBtn.Location = new Point(93, 367);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(75, 23);
            CloseBtn.TabIndex = 1;
            CloseBtn.Text = "Exit";
            CloseBtn.Click += CloseBtn_Click;
            // 
            // bobtest
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 749);
            Controls.Add(CloseBtn);
            Controls.Add(panel1);
            Name = "bobtest";
            Text = "bobtest";
            ResumeLayout(false);
        }

        #endregion

        public Panel panel1;
        private DevExpress.XtraEditors.SimpleButton CloseBtn;
    }
}