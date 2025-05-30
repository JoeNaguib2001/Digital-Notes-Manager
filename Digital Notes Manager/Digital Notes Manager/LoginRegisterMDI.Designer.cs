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
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            panel1 = new Panel();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // loginRegisterMDIPanel
            // 
            loginRegisterMDIPanel.Dock = DockStyle.Fill;
            loginRegisterMDIPanel.Location = new Point(0, 52);
            loginRegisterMDIPanel.Name = "loginRegisterMDIPanel";
            loginRegisterMDIPanel.Size = new Size(600, 299);
            loginRegisterMDIPanel.TabIndex = 0;
            // 
            // simpleButton1
            // 
            simpleButton1.Dock = DockStyle.Left;
            simpleButton1.Location = new Point(0, 0);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(297, 52);
            simpleButton1.TabIndex = 1;
            simpleButton1.Text = "simpleButton1";
            // 
            // panel1
            // 
            panel1.Controls.Add(simpleButton2);
            panel1.Controls.Add(simpleButton1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 52);
            panel1.TabIndex = 2;
            // 
            // simpleButton2
            // 
            simpleButton2.Dock = DockStyle.Right;
            simpleButton2.Location = new Point(295, 0);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new Size(305, 52);
            simpleButton2.TabIndex = 2;
            simpleButton2.Text = "simpleButton2";
            // 
            // LoginRegisterMDI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 351);
            Controls.Add(loginRegisterMDIPanel);
            Controls.Add(panel1);
            Name = "LoginRegisterMDI";
            Text = "LoginRegisterMDI";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel loginRegisterMDIPanel;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}