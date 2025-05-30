namespace Digital_Notes_Manager
{
    partial class Login
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
            userNameLabel = new DevExpress.XtraEditors.LabelControl();
            passwordLabel = new DevExpress.XtraEditors.LabelControl();
            loginBtn = new DevExpress.XtraEditors.SimpleButton();
            userNameTxt = new DevExpress.XtraEditors.TextEdit();
            passwordTxt = new DevExpress.XtraEditors.TextEdit();
            loginPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)userNameTxt.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordTxt.Properties).BeginInit();
            loginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.Appearance.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 178);
            userNameLabel.Appearance.ForeColor = Color.White;
            userNameLabel.Appearance.Options.UseFont = true;
            userNameLabel.Appearance.Options.UseForeColor = true;
            userNameLabel.Location = new Point(49, 28);
            userNameLabel.Margin = new Padding(4, 2, 4, 2);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(164, 37);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.Appearance.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 178);
            passwordLabel.Appearance.ForeColor = Color.White;
            passwordLabel.Appearance.Options.UseFont = true;
            passwordLabel.Appearance.Options.UseForeColor = true;
            passwordLabel.Location = new Point(49, 104);
            passwordLabel.Margin = new Padding(4, 2, 4, 2);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(160, 37);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password:";
            // 
            // loginBtn
            // 
            loginBtn.Appearance.BackColor = Color.FromArgb(20, 150, 150);
            loginBtn.Appearance.Font = new Font("Tahoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.Appearance.ForeColor = Color.White;
            loginBtn.Appearance.Options.UseBackColor = true;
            loginBtn.Appearance.Options.UseFont = true;
            loginBtn.Appearance.Options.UseForeColor = true;
            loginBtn.Location = new Point(233, 187);
            loginBtn.Margin = new Padding(4, 3, 4, 3);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(161, 63);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.Click += loginBtn_Click;
            // 
            // userNameTxt
            // 
            userNameTxt.Location = new Point(261, 23);
            userNameTxt.Margin = new Padding(4, 2, 4, 2);
            userNameTxt.Name = "userNameTxt";
            userNameTxt.Properties.Appearance.BackColor = Color.FromArgb(84, 94, 106);
            userNameTxt.Properties.Appearance.Font = new Font("Tahoma", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameTxt.Properties.Appearance.ForeColor = Color.White;
            userNameTxt.Properties.Appearance.Options.UseBackColor = true;
            userNameTxt.Properties.Appearance.Options.UseFont = true;
            userNameTxt.Properties.Appearance.Options.UseForeColor = true;
            userNameTxt.Size = new Size(281, 42);
            userNameTxt.TabIndex = 5;
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(261, 99);
            passwordTxt.Margin = new Padding(4, 3, 4, 3);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Properties.Appearance.BackColor = Color.FromArgb(84, 94, 106);
            passwordTxt.Properties.Appearance.Font = new Font("Tahoma", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTxt.Properties.Appearance.ForeColor = Color.White;
            passwordTxt.Properties.Appearance.Options.UseBackColor = true;
            passwordTxt.Properties.Appearance.Options.UseFont = true;
            passwordTxt.Properties.Appearance.Options.UseForeColor = true;
            passwordTxt.Properties.PasswordChar = '*';
            passwordTxt.Size = new Size(281, 42);
            passwordTxt.TabIndex = 6;
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.FromArgb(46, 49, 56);
            loginPanel.Controls.Add(loginBtn);
            loginPanel.Controls.Add(passwordTxt);
            loginPanel.Controls.Add(userNameTxt);
            loginPanel.Controls.Add(userNameLabel);
            loginPanel.Controls.Add(passwordLabel);
            loginPanel.Dock = DockStyle.Fill;
            loginPanel.Location = new Point(0, 0);
            loginPanel.Margin = new Padding(4, 3, 4, 3);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(584, 311);
            loginPanel.TabIndex = 7;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(loginPanel);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)userNameTxt.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordTxt.Properties).EndInit();
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl userNameLabel;
        private DevExpress.XtraEditors.LabelControl passwordLabel;
        private DevExpress.XtraEditors.SimpleButton loginBtn;
        private DevExpress.XtraEditors.TextEdit userNameTxt;
        private DevExpress.XtraEditors.TextEdit passwordTxt;
        public Panel loginPanel;
    }
}