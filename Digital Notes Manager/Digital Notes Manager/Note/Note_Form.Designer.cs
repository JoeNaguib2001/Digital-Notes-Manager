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
            stylePanal = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            richTextBox1 = new RichTextBox();
            saveBtn = new DevExpress.XtraEditors.SimpleButton();
            MenuBtn = new DevExpress.XtraEditors.SimpleButton();
            Close_btn = new DevExpress.XtraEditors.SimpleButton();
            Calender = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            TitleBox = new DevExpress.XtraEditors.TextEdit();
            Categorybox = new DevExpress.XtraEditors.ComboBoxEdit();
            DownPanel = new Panel();
            TrashBtn = new DevExpress.XtraEditors.SimpleButton();
            BellButton = new DevExpress.XtraEditors.SimpleButton();
            TopPanal = new Panel();
            IsCompleted = new CheckBox();
            Container = new Panel();
            ((System.ComponentModel.ISupportInitialize)Calender.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TitleBox.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Categorybox.Properties).BeginInit();
            DownPanel.SuspendLayout();
            TopPanal.SuspendLayout();
            Container.SuspendLayout();
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
            richTextBox1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(12, 50);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(377, 254);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // saveBtn
            // 
            saveBtn.ImageOptions.Image = Properties.Resources.disk1;
            saveBtn.Location = new Point(100, 6);
            saveBtn.Name = "saveBtn";
            saveBtn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            saveBtn.Size = new Size(21, 20);
            saveBtn.TabIndex = 4;
            saveBtn.Click += saveBtn_Click;
            // 
            // MenuBtn
            // 
            MenuBtn.Dock = DockStyle.Left;
            MenuBtn.ImageOptions.Image = Properties.Resources.menu;
            MenuBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            MenuBtn.Location = new Point(0, 0);
            MenuBtn.Name = "MenuBtn";
            MenuBtn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            MenuBtn.Size = new Size(36, 33);
            MenuBtn.TabIndex = 5;
            // 
            // Close_btn
            // 
            Close_btn.Appearance.Options.UseBackColor = true;
            Close_btn.Appearance.Options.UseBorderColor = true;
            Close_btn.Dock = DockStyle.Right;
            Close_btn.ImageOptions.Image = Properties.Resources.cross;
            Close_btn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            Close_btn.Location = new Point(372, 0);
            Close_btn.Name = "Close_btn";
            Close_btn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            Close_btn.Size = new Size(29, 33);
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
            TitleBox.Location = new Point(144, -1);
            TitleBox.Name = "TitleBox";
            TitleBox.Properties.AllowFocused = false;
            TitleBox.Properties.Appearance.BackColor = Color.FromArgb(44, 62, 80);
            TitleBox.Properties.Appearance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleBox.Properties.Appearance.ForeColor = Color.White;
            TitleBox.Properties.Appearance.Options.UseBackColor = true;
            TitleBox.Properties.Appearance.Options.UseFont = true;
            TitleBox.Properties.Appearance.Options.UseForeColor = true;
            TitleBox.Properties.Appearance.Options.UseTextOptions = true;
            TitleBox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            TitleBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            TitleBox.Properties.ReadOnly = true;
            TitleBox.Size = new Size(102, 30);
            TitleBox.TabIndex = 8;
            TitleBox.TextChanged += TitleBox_TextChanged;
            TitleBox.DoubleClick += TitleBox_DoubleClick;
            TitleBox.KeyDown += TitleBox_KeyDown;
            TitleBox.Leave += TitleBox_Leave;
            // 
            // Categorybox
            // 
            Categorybox.Location = new Point(273, 4);
            Categorybox.Name = "Categorybox";
            Categorybox.Properties.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Categorybox.Properties.Appearance.Options.UseFont = true;
            Categorybox.Properties.AppearanceDropDown.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Categorybox.Properties.AppearanceDropDown.Options.UseFont = true;
            Categorybox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            Categorybox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            Categorybox.Size = new Size(123, 26);
            Categorybox.TabIndex = 9;
            Categorybox.SelectedIndexChanged += Categorybox_SelectedIndexChanged;
            // 
            // DownPanel
            // 
            DownPanel.Controls.Add(TrashBtn);
            DownPanel.Controls.Add(stylePanal);
            DownPanel.Controls.Add(Categorybox);
            DownPanel.Controls.Add(saveBtn);
            DownPanel.Dock = DockStyle.Bottom;
            DownPanel.Location = new Point(0, 335);
            DownPanel.Name = "DownPanel";
            DownPanel.Size = new Size(401, 34);
            DownPanel.TabIndex = 10;
            // 
            // TrashBtn
            // 
            TrashBtn.ImageOptions.Image = Properties.Resources.trash1;
            TrashBtn.Location = new Point(127, 7);
            TrashBtn.Name = "TrashBtn";
            TrashBtn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            TrashBtn.Size = new Size(20, 20);
            TrashBtn.TabIndex = 11;
            TrashBtn.Click += simpleButton1_Click;
            // 
            // BellButton
            // 
            BellButton.ImageOptions.Image = Properties.Resources.bell1;
            BellButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            BellButton.Location = new Point(42, 0);
            BellButton.Name = "BellButton";
            BellButton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            BellButton.Size = new Size(38, 33);
            BellButton.TabIndex = 10;
            // 
            // TopPanal
            // 
            TopPanal.BackColor = Color.FromArgb(44, 62, 80);
            TopPanal.Controls.Add(IsCompleted);
            TopPanal.Controls.Add(Calender);
            TopPanal.Controls.Add(BellButton);
            TopPanal.Controls.Add(Close_btn);
            TopPanal.Controls.Add(TitleBox);
            TopPanal.Controls.Add(MenuBtn);
            TopPanal.Dock = DockStyle.Top;
            TopPanal.Location = new Point(0, 0);
            TopPanal.Name = "TopPanal";
            TopPanal.Size = new Size(401, 33);
            TopPanal.TabIndex = 11;
            TopPanal.Paint += TopPanal_Paint;
            TopPanal.MouseDown += TopPanal_MouseDown;
            // 
            // IsCompleted
            // 
            IsCompleted.Anchor = AnchorStyles.None;
            IsCompleted.AutoSize = true;
            IsCompleted.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsCompleted.ForeColor = Color.White;
            IsCompleted.Location = new Point(239, 5);
            IsCompleted.Name = "IsCompleted";
            IsCompleted.Size = new Size(102, 23);
            IsCompleted.TabIndex = 11;
            IsCompleted.Text = "checkBox1";
            IsCompleted.UseVisualStyleBackColor = true;
            IsCompleted.Visible = false;
            IsCompleted.CheckedChanged += IsCompleted_CheckedChanged;
            // 
            // Container
            // 
            Container.BackColor = Color.White;
            Container.Controls.Add(richTextBox1);
            Container.Controls.Add(TopPanal);
            Container.Controls.Add(DownPanel);
            Container.Dock = DockStyle.Fill;
            Container.Location = new Point(0, 0);
            Container.Name = "Container";
            Container.Size = new Size(401, 369);
            Container.TabIndex = 12;
            Container.Paint += Container_Paint;
            // 
            // Note_Form
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 369);
            Controls.Add(Container);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Note_Form";
            Text = "Note";
            FormClosed += Note_Form_FormClosed;
            ((System.ComponentModel.ISupportInitialize)Calender.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TitleBox.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Categorybox.Properties).EndInit();
            DownPanel.ResumeLayout(false);
            TopPanal.ResumeLayout(false);
            TopPanal.PerformLayout();
            Container.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel stylePanal;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.SimpleButton MenuBtn;
        private DevExpress.XtraEditors.SimpleButton Close_btn;
        public RichTextBox richTextBox1;
        private DevExpress.XtraEditors.DateTimeOffsetEdit Calender;
        private DevExpress.XtraEditors.SimpleButton BellButton;
        public DevExpress.XtraEditors.ComboBoxEdit Categorybox;
        public Panel Container;
        public Panel DownPanel;
        public Panel TopPanal;
        public DevExpress.XtraEditors.TextEdit TitleBox;
        private DevExpress.XtraEditors.SimpleButton TrashBtn;
        private CheckBox IsCompleted;
    }
}