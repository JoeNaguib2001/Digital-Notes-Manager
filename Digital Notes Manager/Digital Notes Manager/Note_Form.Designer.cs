namespace Digital_Notes_Manager
{
    partial class Note_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Note_Form));
            stylePanal = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            richTextBox1 = new RichTextBox();
            saveBtn = new DevExpress.XtraEditors.SimpleButton();
            MenuBtn = new DevExpress.XtraEditors.SimpleButton();
            Close_btn = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // stylePanal
            // 
            stylePanal.AppearanceButton.Normal.ForeColor = Color.Gray;
            stylePanal.AppearanceButton.Normal.Options.UseForeColor = true;
            stylePanal.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] { new DevExpress.XtraBars.Docking2010.WindowsUIButton(), new DevExpress.XtraBars.Docking2010.WindowsUIButton() });
            stylePanal.Location = new Point(2, 224);
            stylePanal.Name = "stylePanal";
            stylePanal.Size = new Size(92, 20);
            stylePanal.TabIndex = 2;
            stylePanal.Text = "windowsuiButtonPanel1";
            stylePanal.ButtonUnchecked += stylePanal_ButtonUnchecked;
            stylePanal.ButtonChecked += StylePanal_ButtonChecked;
            stylePanal.Click += stylePanal_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(2, 41);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(260, 183);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // saveBtn
            // 
            saveBtn.ImageOptions.Image = (Image)resources.GetObject("saveBtn.ImageOptions.Image");
            saveBtn.Location = new Point(91, 224);
            saveBtn.Name = "saveBtn";
            saveBtn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            saveBtn.Size = new Size(21, 20);
            saveBtn.TabIndex = 4;
            // 
            // MenuBtn
            // 
            MenuBtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("MenuBtn.ImageOptions.SvgImage");
            MenuBtn.Location = new Point(190, 12);
            MenuBtn.Name = "MenuBtn";
            MenuBtn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            MenuBtn.Size = new Size(39, 23);
            MenuBtn.TabIndex = 5;
            MenuBtn.Click += MenuBtn_Click;
            // 
            // Close_btn
            // 
            Close_btn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("Close_btn.ImageOptions.SvgImage");
            Close_btn.Location = new Point(235, 12);
            Close_btn.Name = "Close_btn";
            Close_btn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            Close_btn.Size = new Size(37, 23);
            Close_btn.TabIndex = 6;
            Close_btn.Click += Close_btn_Click_1;
            // 
            // Note_Form
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 250);
            Controls.Add(Close_btn);
            Controls.Add(MenuBtn);
            Controls.Add(saveBtn);
            Controls.Add(richTextBox1);
            Controls.Add(stylePanal);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Note_Form";
            Text = "Note";
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel stylePanal;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.SimpleButton MenuBtn;
        private DevExpress.XtraEditors.SimpleButton Close_btn;
        public RichTextBox richTextBox1;
    }
}