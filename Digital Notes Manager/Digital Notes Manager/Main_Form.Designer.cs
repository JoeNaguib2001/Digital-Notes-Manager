namespace Digital_Notes_Manager
{
    partial class Main_Form
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            noteIOToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            View_My_Notes_Accordion_Element = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            Add_New_Note_Accordion_Element = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            MDI_Panel = new Panel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)accordionControl1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1122, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { noteIOToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // noteIOToolStripMenuItem
            // 
            noteIOToolStripMenuItem.Name = "noteIOToolStripMenuItem";
            noteIOToolStripMenuItem.RightToLeft = RightToLeft.No;
            noteIOToolStripMenuItem.Size = new Size(208, 26);
            noteIOToolStripMenuItem.Text = "Import New Note";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // accordionControl1
            // 
            accordionControl1.Appearance.AccordionControl.BackColor = Color.FromArgb(46, 49, 56);
            accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
            accordionControl1.Dock = DockStyle.Left;
            accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlElement1 });
            accordionControl1.Location = new Point(0, 28);
            accordionControl1.LookAndFeel.SkinName = "Office 2013 Dark Gray";
            accordionControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            accordionControl1.Name = "accordionControl1";
            accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            accordionControl1.Size = new Size(234, 695);
            accordionControl1.TabIndex = 1;
            // 
            // accordionControlElement1
            // 
            accordionControlElement1.Appearance.Default.BackColor = Color.FromArgb(46, 49, 56);
            accordionControlElement1.Appearance.Default.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accordionControlElement1.Appearance.Default.ForeColor = Color.White;
            accordionControlElement1.Appearance.Default.Options.UseBackColor = true;
            accordionControlElement1.Appearance.Default.Options.UseFont = true;
            accordionControlElement1.Appearance.Default.Options.UseForeColor = true;
            accordionControlElement1.Appearance.Hovered.BackColor = Color.FromArgb(205, 230, 247);
            accordionControlElement1.Appearance.Hovered.ForeColor = Color.Black;
            accordionControlElement1.Appearance.Hovered.Options.UseBackColor = true;
            accordionControlElement1.Appearance.Hovered.Options.UseForeColor = true;
            accordionControlElement1.Appearance.Pressed.BackColor = Color.FromArgb(205, 230, 247);
            accordionControlElement1.Appearance.Pressed.ForeColor = Color.Black;
            accordionControlElement1.Appearance.Pressed.Options.UseBackColor = true;
            accordionControlElement1.Appearance.Pressed.Options.UseForeColor = true;
            accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { View_My_Notes_Accordion_Element, Add_New_Note_Accordion_Element });
            accordionControlElement1.Expanded = true;
            accordionControlElement1.Name = "accordionControlElement1";
            accordionControlElement1.Text = "My Notes";
            // 
            // View_My_Notes_Accordion_Element
            // 
            View_My_Notes_Accordion_Element.Appearance.Default.BackColor = Color.FromArgb(46, 49, 56);
            View_My_Notes_Accordion_Element.Appearance.Default.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            View_My_Notes_Accordion_Element.Appearance.Default.ForeColor = Color.White;
            View_My_Notes_Accordion_Element.Appearance.Default.Options.UseBackColor = true;
            View_My_Notes_Accordion_Element.Appearance.Default.Options.UseFont = true;
            View_My_Notes_Accordion_Element.Appearance.Default.Options.UseForeColor = true;
            View_My_Notes_Accordion_Element.Appearance.Hovered.BackColor = Color.FromArgb(205, 230, 247);
            View_My_Notes_Accordion_Element.Appearance.Hovered.ForeColor = Color.Black;
            View_My_Notes_Accordion_Element.Appearance.Hovered.Options.UseBackColor = true;
            View_My_Notes_Accordion_Element.Appearance.Hovered.Options.UseForeColor = true;
            View_My_Notes_Accordion_Element.Appearance.Pressed.BackColor = Color.FromArgb(205, 230, 247);
            View_My_Notes_Accordion_Element.Appearance.Pressed.ForeColor = Color.Black;
            View_My_Notes_Accordion_Element.Appearance.Pressed.Options.UseBackColor = true;
            View_My_Notes_Accordion_Element.Appearance.Pressed.Options.UseForeColor = true;
            View_My_Notes_Accordion_Element.Name = "View_My_Notes_Accordion_Element";
            View_My_Notes_Accordion_Element.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            View_My_Notes_Accordion_Element.Text = "View My Notes";
            // 
            // Add_New_Note_Accordion_Element
            // 
            Add_New_Note_Accordion_Element.Appearance.Default.BackColor = Color.FromArgb(46, 49, 56);
            Add_New_Note_Accordion_Element.Appearance.Default.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add_New_Note_Accordion_Element.Appearance.Default.ForeColor = Color.White;
            Add_New_Note_Accordion_Element.Appearance.Default.Options.UseBackColor = true;
            Add_New_Note_Accordion_Element.Appearance.Default.Options.UseFont = true;
            Add_New_Note_Accordion_Element.Appearance.Default.Options.UseForeColor = true;
            Add_New_Note_Accordion_Element.Appearance.Hovered.BackColor = Color.FromArgb(205, 230, 247);
            Add_New_Note_Accordion_Element.Appearance.Hovered.ForeColor = Color.Black;
            Add_New_Note_Accordion_Element.Appearance.Hovered.Options.UseBackColor = true;
            Add_New_Note_Accordion_Element.Appearance.Hovered.Options.UseForeColor = true;
            Add_New_Note_Accordion_Element.Appearance.Pressed.BackColor = Color.FromArgb(205, 230, 247);
            Add_New_Note_Accordion_Element.Appearance.Pressed.ForeColor = Color.Black;
            Add_New_Note_Accordion_Element.Appearance.Pressed.Options.UseBackColor = true;
            Add_New_Note_Accordion_Element.Appearance.Pressed.Options.UseForeColor = true;
            Add_New_Note_Accordion_Element.Name = "Add_New_Note_Accordion_Element";
            Add_New_Note_Accordion_Element.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            Add_New_Note_Accordion_Element.Text = "Add New Note";
            // 
            // MDI_Panel
            // 
            MDI_Panel.Dock = DockStyle.Fill;
            MDI_Panel.Location = new Point(234, 28);
            MDI_Panel.Name = "MDI_Panel";
            MDI_Panel.Size = new Size(888, 695);
            MDI_Panel.TabIndex = 2;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 723);
            Controls.Add(MDI_Panel);
            Controls.Add(accordionControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main_Form";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)accordionControl1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Add_New_Note_Accordion_Element;
        private Panel MDI_Panel;
        private DevExpress.XtraBars.Navigation.AccordionControlElement View_My_Notes_Accordion_Element;
        private ToolStripMenuItem noteIOToolStripMenuItem;
    }
}