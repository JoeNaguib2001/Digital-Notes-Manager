namespace Digital_Notes_Manager
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            NotePanel = new Panel();
            PreviousBtn = new DevExpress.XtraEditors.SimpleButton();
            NextBtn = new DevExpress.XtraEditors.SimpleButton();
            NotePanel.SuspendLayout();
            SuspendLayout();
            // 
            // NotePanel
            // 
            NotePanel.Controls.Add(PreviousBtn);
            NotePanel.Controls.Add(NextBtn);
            NotePanel.Dock = DockStyle.Bottom;
            NotePanel.Location = new Point(0, 359);
            NotePanel.Name = "NotePanel";
            NotePanel.Size = new Size(693, 322);
            NotePanel.TabIndex = 2;
            // 
            // PreviousBtn
            // 
            PreviousBtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("PreviousBtn.ImageOptions.SvgImage");
            PreviousBtn.Location = new Point(145, 239);
            PreviousBtn.Name = "PreviousBtn";
            PreviousBtn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            PreviousBtn.Size = new Size(41, 46);
            PreviousBtn.TabIndex = 1;
            PreviousBtn.Click += PreviousBtn_Click;
            // 
            // NextBtn
            // 
            NextBtn.ImageOptions.ImageIndex = 1;
            NextBtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("NextBtn.ImageOptions.SvgImage");
            NextBtn.Location = new Point(490, 239);
            NextBtn.Name = "NextBtn";
            NextBtn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            NextBtn.Size = new Size(37, 46);
            NextBtn.TabIndex = 1;
            NextBtn.Click += NextBtn_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 681);
            Controls.Add(NotePanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashboard";
            NotePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton PreviousBtn;
        private DevExpress.XtraEditors.SimpleButton NextBtn;
        public Panel NotePanel;
    }
}