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
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            NotePanel = new DevExpress.XtraEditors.PanelControl();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)NotePanel).BeginInit();
            SuspendLayout();
            // 
            // simpleButton1
            // 
            simpleButton1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton1.ImageOptions.SvgImage");
            simpleButton1.Location = new Point(742, 12);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            simpleButton1.Size = new Size(34, 23);
            simpleButton1.TabIndex = 0;
            // 
            // NotePanel
            // 
            NotePanel.Location = new Point(243, 41);
            NotePanel.Name = "NotePanel";
            NotePanel.Size = new Size(545, 397);
            NotePanel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 402);
            panel1.TabIndex = 2;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(NotePanel);
            Controls.Add(simpleButton1);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)NotePanel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PanelControl NotePanel;
        private Panel panel1;
    }
}