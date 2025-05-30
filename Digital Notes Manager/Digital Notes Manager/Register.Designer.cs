namespace Digital_Notes_Manager
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            usernameLabel = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            usernameTxt = new DevExpress.XtraEditors.TextEdit();
            passwordConfirmTxt = new DevExpress.XtraEditors.TextEdit();
            passwordTxt = new DevExpress.XtraEditors.TextEdit();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            SinUpBtn = new DevExpress.XtraEditors.SimpleButton();
            registerPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)usernameTxt.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordConfirmTxt.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordTxt.Properties).BeginInit();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.Appearance.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            usernameLabel.Appearance.ForeColor = SystemColors.ActiveCaptionText;
            usernameLabel.Appearance.Options.UseFont = true;
            usernameLabel.Appearance.Options.UseForeColor = true;
            usernameLabel.Location = new Point(64, 89);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(104, 26);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            labelControl1.Appearance.ForeColor = SystemColors.ActiveCaptionText;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new Point(64, 154);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(104, 26);
            labelControl1.TabIndex = 1;
            labelControl1.Text = "Password";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            labelControl2.Appearance.ForeColor = SystemColors.ActiveCaptionText;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new Point(64, 219);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(191, 26);
            labelControl2.TabIndex = 2;
            labelControl2.Text = "Confirm Password";
            // 
            // usernameTxt
            // 
            usernameTxt.EnterMoveNextControl = true;
            usernameTxt.Location = new Point(283, 80);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Properties.Appearance.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTxt.Properties.Appearance.Options.UseFont = true;
            usernameTxt.Size = new Size(173, 36);
            usernameTxt.TabIndex = 3;
            // 
            // passwordConfirmTxt
            // 
            passwordConfirmTxt.Location = new Point(283, 210);
            passwordConfirmTxt.Name = "passwordConfirmTxt";
            passwordConfirmTxt.Properties.Appearance.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordConfirmTxt.Properties.Appearance.Options.UseFont = true;
            passwordConfirmTxt.Properties.PasswordChar = '*';
            passwordConfirmTxt.Size = new Size(173, 36);
            passwordConfirmTxt.TabIndex = 4;
            // 
            // passwordTxt
            // 
            passwordTxt.EnterMoveNextControl = true;
            passwordTxt.Location = new Point(283, 145);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Properties.Appearance.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTxt.Properties.Appearance.Options.UseFont = true;
            passwordTxt.Properties.PasswordChar = '*';
            passwordTxt.Size = new Size(173, 36);
            passwordTxt.TabIndex = 5;
            // 
            // simpleButton1
            // 
            simpleButton1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton1.ImageOptions.SvgImage");
            simpleButton1.Location = new Point(472, 12);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            simpleButton1.Size = new Size(38, 23);
            simpleButton1.TabIndex = 6;
            simpleButton1.Click += simpleButton1_Click;
            // 
            // SinUpBtn
            // 
            SinUpBtn.Appearance.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SinUpBtn.Appearance.Options.UseFont = true;
            SinUpBtn.Location = new Point(172, 295);
            SinUpBtn.Name = "SinUpBtn";
            SinUpBtn.Size = new Size(173, 51);
            SinUpBtn.TabIndex = 7;
            SinUpBtn.Text = "Sign Up";
            SinUpBtn.Click += SinUpBtn_Click;
            // 
            // registerPanel
            // 
            registerPanel.Dock = DockStyle.Fill;
            registerPanel.Location = new Point(0, 0);
            registerPanel.Name = "registerPanel";
            registerPanel.Size = new Size(521, 390);
            registerPanel.TabIndex = 8;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 390);
            Controls.Add(SinUpBtn);
            Controls.Add(simpleButton1);
            Controls.Add(passwordTxt);
            Controls.Add(passwordConfirmTxt);
            Controls.Add(usernameTxt);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Controls.Add(usernameLabel);
            Controls.Add(registerPanel);
            Name = "Register";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)usernameTxt.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordConfirmTxt.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordTxt.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl usernameLabel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit usernameTxt;
        private DevExpress.XtraEditors.TextEdit passwordConfirmTxt;
        private DevExpress.XtraEditors.TextEdit passwordTxt;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton SinUpBtn;
        public Panel registerPanel;
    }
}