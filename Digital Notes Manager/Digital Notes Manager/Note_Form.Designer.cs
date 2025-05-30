﻿namespace Digital_Notes_Manager
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
            Calender = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            TitleBox = new DevExpress.XtraEditors.TextEdit();
            Categorybox = new DevExpress.XtraEditors.ComboBoxEdit();
            DownPanel = new Panel();
            BellButton = new DevExpress.XtraEditors.SimpleButton();
            TopPanal = new Panel();
            ((System.ComponentModel.ISupportInitialize)Calender.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TitleBox.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Categorybox.Properties).BeginInit();
            DownPanel.SuspendLayout();
            TopPanal.SuspendLayout();
            SuspendLayout();
            // 
            // stylePanal
            // 
            stylePanal.AppearanceButton.Normal.ForeColor = Color.Gray;
            stylePanal.AppearanceButton.Normal.Options.UseForeColor = true;
            stylePanal.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] { new DevExpress.XtraBars.Docking2010.WindowsUIButton(), new DevExpress.XtraBars.Docking2010.WindowsUIButton() });
            stylePanal.Location = new Point(3, 5);
            stylePanal.Name = "stylePanal";
            stylePanal.Size = new Size(92, 20);
            stylePanal.TabIndex = 2;
            stylePanal.Text = "windowsuiButtonPanel1";
            stylePanal.ButtonUnchecked += stylePanal_ButtonUnchecked;
            stylePanal.ButtonChecked += StylePanal_ButtonChecked;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(8, 37);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(260, 179);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // saveBtn
            // 
            saveBtn.ImageOptions.Image = (Image)resources.GetObject("saveBtn.ImageOptions.Image");
            saveBtn.Location = new Point(100, 5);
            saveBtn.Name = "saveBtn";
            saveBtn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            saveBtn.Size = new Size(21, 20);
            saveBtn.TabIndex = 4;
            saveBtn.Click += saveBtn_Click;
            // 
            // MenuBtn
            // 
            MenuBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            MenuBtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("MenuBtn.ImageOptions.SvgImage");
            MenuBtn.Location = new Point(0, 0);
            MenuBtn.Name = "MenuBtn";
            MenuBtn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            MenuBtn.Size = new Size(62, 33);
            MenuBtn.TabIndex = 5;
            // 
            // Close_btn
            // 
            Close_btn.Appearance.Options.UseBackColor = true;
            Close_btn.Appearance.Options.UseBorderColor = true;
            Close_btn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            Close_btn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("Close_btn.ImageOptions.SvgImage");
            Close_btn.Location = new Point(236, 0);
            Close_btn.Name = "Close_btn";
            Close_btn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            Close_btn.Size = new Size(41, 33);
            Close_btn.TabIndex = 6;
            Close_btn.Click += Close_btn_Click;
            // 
            // Calender
            // 
            Calender.EditValue = null;
            Calender.Location = new Point(30, 8);
            Calender.Name = "Calender";
            Calender.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            Calender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            Calender.Properties.DisplayFormat.FormatString = "d";
            Calender.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            Calender.Properties.EditFormat.FormatString = "d";
            Calender.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            Calender.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            Calender.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeOffsetMaskManager));
            Calender.Properties.MaskSettings.Set("mask", "f");
            Calender.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            Calender.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.NoBorder;
            Calender.Size = new Size(21, 18);
            Calender.TabIndex = 7;
            Calender.Visible = false;
            Calender.EditValueChanged += Calender_EditValueChanged;
            // 
            // TitleBox
            // 
            TitleBox.EditValue = "Note";
            TitleBox.Location = new Point(100, 3);
            TitleBox.Name = "TitleBox";
            TitleBox.Properties.AllowFocused = false;
            TitleBox.Properties.Appearance.BackColor = Color.WhiteSmoke;
            TitleBox.Properties.Appearance.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleBox.Properties.Appearance.Options.UseBackColor = true;
            TitleBox.Properties.Appearance.Options.UseFont = true;
            TitleBox.Properties.Appearance.Options.UseTextOptions = true;
            TitleBox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            TitleBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            TitleBox.Properties.ReadOnly = true;
            TitleBox.Size = new Size(86, 24);
            TitleBox.TabIndex = 8;
            TitleBox.DoubleClick += TitleBox_DoubleClick;
            TitleBox.KeyDown += TitleBox_KeyDown;
            TitleBox.Leave += TitleBox_Leave;
            // 
            // Categorybox
            // 
            Categorybox.Location = new Point(162, 5);
            Categorybox.Name = "Categorybox";
            Categorybox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            Categorybox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            Categorybox.Size = new Size(100, 20);
            Categorybox.TabIndex = 9;
            Categorybox.SelectedIndexChanged += Categorybox_SelectedIndexChanged;
            // 
            // DownPanel
            // 
            DownPanel.Controls.Add(stylePanal);
            DownPanel.Controls.Add(Categorybox);
            DownPanel.Controls.Add(saveBtn);
            DownPanel.Dock = DockStyle.Bottom;
            DownPanel.Location = new Point(0, 194);
            DownPanel.Name = "DownPanel";
            DownPanel.Size = new Size(274, 28);
            DownPanel.TabIndex = 10;
            // 
            // BellButton
            // 
            BellButton.ImageOptions.Image = Properties.Resources.bell1;
            BellButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            BellButton.Location = new Point(57, 0);
            BellButton.Name = "BellButton";
            BellButton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            BellButton.Size = new Size(38, 33);
            BellButton.TabIndex = 10;
            // 
            // TopPanal
            // 
            TopPanal.Controls.Add(Calender);
            TopPanal.Controls.Add(BellButton);
            TopPanal.Controls.Add(Close_btn);
            TopPanal.Controls.Add(TitleBox);
            TopPanal.Controls.Add(MenuBtn);
            TopPanal.Dock = DockStyle.Top;
            TopPanal.Location = new Point(0, 0);
            TopPanal.Name = "TopPanal";
            TopPanal.Size = new Size(274, 33);
            TopPanal.TabIndex = 11;
            TopPanal.MouseDown += TopPanal_MouseDown;
            // 
            // Note_Form
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 222);
            Controls.Add(TopPanal);
            Controls.Add(DownPanel);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Note_Form";
            Text = "Note";
            ((System.ComponentModel.ISupportInitialize)Calender.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TitleBox.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Categorybox.Properties).EndInit();
            DownPanel.ResumeLayout(false);
            TopPanal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel stylePanal;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.SimpleButton MenuBtn;
        private DevExpress.XtraEditors.SimpleButton Close_btn;
        public RichTextBox richTextBox1;
        private DevExpress.XtraEditors.DateTimeOffsetEdit Calender;
        private DevExpress.XtraEditors.TextEdit TitleBox;
        private Panel DownPanel;
        private DevExpress.XtraEditors.SimpleButton BellButton;
        private Panel TopPanal;
        public DevExpress.XtraEditors.ComboBoxEdit Categorybox;
    }
}