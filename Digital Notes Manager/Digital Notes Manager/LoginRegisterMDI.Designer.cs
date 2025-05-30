namespace Digital_Notes_Manager
{
    partial class LoginRegisterMDI
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
            loginRegisterMDIPanel = new Panel();
            loginBtnFromMDI = new DevExpress.XtraEditors.SimpleButton();
            panel1 = new Panel();
            registerBtnFromMDI = new DevExpress.XtraEditors.SimpleButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // loginRegisterMDIPanel
            // 
            loginRegisterMDIPanel.Dock = DockStyle.Fill;
            loginRegisterMDIPanel.Location = new Point(0, 52);
            loginRegisterMDIPanel.Name = "loginRegisterMDIPanel";
            loginRegisterMDIPanel.Size = new Size(673, 389);
            loginRegisterMDIPanel.TabIndex = 0;
            // 
            // loginBtnFromMDI
            // 
            loginBtnFromMDI.Appearance.BackColor = Color.FromArgb(0, 150, 180);
            loginBtnFromMDI.Appearance.BorderColor = Color.FromArgb(0, 150, 180);
            loginBtnFromMDI.Appearance.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtnFromMDI.Appearance.ForeColor = Color.White;
            loginBtnFromMDI.Appearance.Options.UseBackColor = true;
            loginBtnFromMDI.Appearance.Options.UseBorderColor = true;
            loginBtnFromMDI.Appearance.Options.UseFont = true;
            loginBtnFromMDI.Appearance.Options.UseForeColor = true;
            loginBtnFromMDI.Cursor = Cursors.Hand;
            loginBtnFromMDI.Dock = DockStyle.Left;
            loginBtnFromMDI.Location = new Point(0, 0);
            loginBtnFromMDI.Name = "loginBtnFromMDI";
            loginBtnFromMDI.Size = new Size(336, 52);
            loginBtnFromMDI.TabIndex = 1;
            loginBtnFromMDI.Text = "Login";
            loginBtnFromMDI.Click += loginBtnFromMDI_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(registerBtnFromMDI);
            panel1.Controls.Add(loginBtnFromMDI);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(673, 52);
            panel1.TabIndex = 2;
            // 
            // registerBtnFromMDI
            // 
            registerBtnFromMDI.Appearance.BackColor = Color.FromArgb(0, 150, 180);
            registerBtnFromMDI.Appearance.BorderColor = Color.FromArgb(0, 150, 180);
            registerBtnFromMDI.Appearance.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerBtnFromMDI.Appearance.ForeColor = Color.White;
            registerBtnFromMDI.Appearance.Options.UseBackColor = true;
            registerBtnFromMDI.Appearance.Options.UseBorderColor = true;
            registerBtnFromMDI.Appearance.Options.UseFont = true;
            registerBtnFromMDI.Appearance.Options.UseForeColor = true;
            registerBtnFromMDI.Cursor = Cursors.Hand;
            registerBtnFromMDI.Dock = DockStyle.Right;
            registerBtnFromMDI.Location = new Point(335, 0);
            registerBtnFromMDI.Name = "registerBtnFromMDI";
            registerBtnFromMDI.Size = new Size(338, 52);
            registerBtnFromMDI.TabIndex = 2;
            registerBtnFromMDI.Text = "Register";
            registerBtnFromMDI.Click += registerBtnFromMDI_Click;
            // 
            // LoginRegisterMDI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 441);
            Controls.Add(loginRegisterMDIPanel);
            Controls.Add(panel1);
            Name = "LoginRegisterMDI";
            Text = "LoginRegisterMDI";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel loginRegisterMDIPanel;
        private DevExpress.XtraEditors.SimpleButton loginBtnFromMDI;
        private Panel panel1;
        private DevExpress.XtraEditors.SimpleButton registerBtnFromMDI;
    }
}