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
            usernameLabel = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            usernameTxt = new DevExpress.XtraEditors.TextEdit();
            passwordConfirmTxt = new DevExpress.XtraEditors.TextEdit();
            passwordTxt = new DevExpress.XtraEditors.TextEdit();
            SinUpBtn = new DevExpress.XtraEditors.SimpleButton();
            registerPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)usernameTxt.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordConfirmTxt.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordTxt.Properties).BeginInit();
            registerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.Appearance.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.Appearance.ForeColor = Color.Gainsboro;
            usernameLabel.Appearance.Options.UseFont = true;
            usernameLabel.Appearance.Options.UseForeColor = true;
            usernameLabel.Location = new Point(89, 44);
            usernameLabel.Margin = new Padding(4, 3, 4, 3);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(122, 36);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl1.Appearance.ForeColor = Color.Gainsboro;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new Point(89, 119);
            labelControl1.Margin = new Padding(4, 3, 4, 3);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(115, 36);
            labelControl1.TabIndex = 1;
            labelControl1.Text = "Password";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl2.Appearance.ForeColor = Color.Gainsboro;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new Point(89, 194);
            labelControl2.Margin = new Padding(4, 3, 4, 3);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(221, 36);
            labelControl2.TabIndex = 2;
            labelControl2.Text = "Confirm Password";
            // 
            // usernameTxt
            // 
            usernameTxt.EnterMoveNextControl = true;
            usernameTxt.Location = new Point(389, 44);
            usernameTxt.Margin = new Padding(4, 2, 4, 2);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Properties.Appearance.BackColor = Color.FromArgb(45, 47, 59);
            usernameTxt.Properties.Appearance.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTxt.Properties.Appearance.Options.UseBackColor = true;
            usernameTxt.Properties.Appearance.Options.UseFont = true;
            usernameTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            usernameTxt.Size = new Size(230, 42);
            usernameTxt.TabIndex = 3;
            // 
            // passwordConfirmTxt
            // 
            passwordConfirmTxt.Location = new Point(389, 194);
            passwordConfirmTxt.Margin = new Padding(4, 2, 4, 2);
            passwordConfirmTxt.Name = "passwordConfirmTxt";
            passwordConfirmTxt.Properties.Appearance.BackColor = Color.FromArgb(45, 47, 59);
            passwordConfirmTxt.Properties.Appearance.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordConfirmTxt.Properties.Appearance.Options.UseBackColor = true;
            passwordConfirmTxt.Properties.Appearance.Options.UseFont = true;
            passwordConfirmTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            passwordConfirmTxt.Properties.PasswordChar = '*';
            passwordConfirmTxt.Size = new Size(230, 42);
            passwordConfirmTxt.TabIndex = 4;
            // 
            // passwordTxt
            // 
            passwordTxt.EnterMoveNextControl = true;
            passwordTxt.Location = new Point(389, 116);
            passwordTxt.Margin = new Padding(4, 2, 4, 2);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Properties.Appearance.BackColor = Color.FromArgb(45, 47, 59);
            passwordTxt.Properties.Appearance.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTxt.Properties.Appearance.Options.UseBackColor = true;
            passwordTxt.Properties.Appearance.Options.UseFont = true;
            passwordTxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            passwordTxt.Properties.PasswordChar = '*';
            passwordTxt.Size = new Size(230, 42);
            passwordTxt.TabIndex = 5;
            // 
            // SinUpBtn
            // 
            SinUpBtn.Appearance.BackColor = Color.FromArgb(0, 191, 140);
            SinUpBtn.Appearance.BorderColor = Color.FromArgb(0, 191, 140);
            SinUpBtn.Appearance.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SinUpBtn.Appearance.ForeColor = Color.White;
            SinUpBtn.Appearance.Options.UseBackColor = true;
            SinUpBtn.Appearance.Options.UseBorderColor = true;
            SinUpBtn.Appearance.Options.UseFont = true;
            SinUpBtn.Appearance.Options.UseForeColor = true;
            SinUpBtn.Cursor = Cursors.Hand;
            SinUpBtn.Location = new Point(255, 290);
            SinUpBtn.Margin = new Padding(4, 3, 4, 3);
            SinUpBtn.Name = "SinUpBtn";
            SinUpBtn.Size = new Size(183, 66);
            SinUpBtn.TabIndex = 7;
            SinUpBtn.Text = "Sign Up";
            SinUpBtn.Click += SinUpBtn_Click;
            // 
            // registerPanel
            // 
            registerPanel.BackColor = Color.FromArgb(30, 30, 46);
            registerPanel.Controls.Add(SinUpBtn);
            registerPanel.Controls.Add(usernameLabel);
            registerPanel.Controls.Add(passwordTxt);
            registerPanel.Controls.Add(labelControl1);
            registerPanel.Controls.Add(passwordConfirmTxt);
            registerPanel.Controls.Add(labelControl2);
            registerPanel.Controls.Add(usernameTxt);
            registerPanel.Dock = DockStyle.Fill;
            registerPanel.Location = new Point(0, 0);
            registerPanel.Margin = new Padding(4, 3, 4, 3);
            registerPanel.Name = "registerPanel";
            registerPanel.Size = new Size(700, 404);
            registerPanel.TabIndex = 8;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 404);
            Controls.Add(registerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Register";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)usernameTxt.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordConfirmTxt.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordTxt.Properties).EndInit();
            registerPanel.ResumeLayout(false);
            registerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl usernameLabel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit usernameTxt;
        private DevExpress.XtraEditors.TextEdit passwordConfirmTxt;
        private DevExpress.XtraEditors.TextEdit passwordTxt;
        public Panel registerPanel;
        private DevExpress.XtraEditors.SimpleButton SinUpBtn;
    }
}