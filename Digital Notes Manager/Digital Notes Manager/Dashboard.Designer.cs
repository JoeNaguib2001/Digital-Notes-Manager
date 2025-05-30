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
            CloseBtn = new DevExpress.XtraEditors.SimpleButton();
            sidePanel = new Panel();
            NotePanel = new Panel();
            PreviousBtn = new DevExpress.XtraEditors.SimpleButton();
            NextBtn = new DevExpress.XtraEditors.SimpleButton();
            NotePanel.SuspendLayout();
            SuspendLayout();
            // 
            // CloseBtn
            // 
            CloseBtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("CloseBtn.ImageOptions.SvgImage");
            CloseBtn.Location = new Point(742, 12);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            CloseBtn.Size = new Size(34, 23);
            CloseBtn.TabIndex = 0;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // sidePanel
            // 
            sidePanel.Location = new Point(12, 41);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(161, 389);
            sidePanel.TabIndex = 1;
            // 
            // NotePanel
            // 
            NotePanel.Controls.Add(PreviousBtn);
            NotePanel.Controls.Add(NextBtn);
            NotePanel.Location = new Point(179, 41);
            NotePanel.Name = "NotePanel";
            NotePanel.Size = new Size(609, 389);
            NotePanel.TabIndex = 2;
            // 
            // PreviousBtn
            // 
            PreviousBtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("PreviousBtn.ImageOptions.SvgImage");
            PreviousBtn.Location = new Point(178, 212);
            PreviousBtn.Name = "PreviousBtn";
            PreviousBtn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            PreviousBtn.Size = new Size(41, 46);
            PreviousBtn.TabIndex = 1;
            PreviousBtn.Click += PreviousBtn_Click;
            // 
            // NextBtn
            // 
            NextBtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("NextBtn.ImageOptions.SvgImage");
            NextBtn.Location = new Point(457, 212);
            NextBtn.Name = "NextBtn";
            NextBtn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            NextBtn.Size = new Size(37, 46);
            NextBtn.TabIndex = 0;
            NextBtn.Click += NextBtn_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 442);
            Controls.Add(NotePanel);
            Controls.Add(sidePanel);
            Controls.Add(CloseBtn);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            NotePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton CloseBtn;
        private Panel sidePanel;
        private Panel NotePanel;
        private DevExpress.XtraEditors.SimpleButton PreviousBtn;
        private DevExpress.XtraEditors.SimpleButton NextBtn;
    }
}