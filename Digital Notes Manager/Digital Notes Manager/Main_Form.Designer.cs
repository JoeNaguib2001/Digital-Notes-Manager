﻿namespace Digital_Notes_Manager
{
    partial class Main_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            NotesGroupAccordionElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            Show_Notes_Accordion_Element = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlSeparator3 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            Add_A_New_Note_Accordion_Element = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlSeparator4 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            View_All_Notes_Popped = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlSeparator5 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            LogoutAccordionElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlSeparator2 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            importNoteToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            MDI_Panel = new Panel();
            ((System.ComponentModel.ISupportInitialize)accordionControl1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // accordionControl1
            // 
            accordionControl1.Appearance.AccordionControl.BackColor = Color.FromArgb(222, 233, 239);
            accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
            accordionControl1.Dock = DockStyle.Left;
            accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { NotesGroupAccordionElement, accordionControlSeparator1, LogoutAccordionElement, accordionControlSeparator2 });
            accordionControl1.Location = new Point(0, 24);
            accordionControl1.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            accordionControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            accordionControl1.Name = "accordionControl1";
            accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            accordionControl1.Size = new Size(260, 750);
            accordionControl1.TabIndex = 0;
            accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // NotesGroupAccordionElement
            // 
            NotesGroupAccordionElement.Appearance.Default.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NotesGroupAccordionElement.Appearance.Default.ForeColor = Color.White;
            NotesGroupAccordionElement.Appearance.Default.Options.UseFont = true;
            NotesGroupAccordionElement.Appearance.Default.Options.UseForeColor = true;
            NotesGroupAccordionElement.Appearance.Hovered.BackColor = Color.FromArgb(205, 230, 247);
            NotesGroupAccordionElement.Appearance.Hovered.ForeColor = Color.Black;
            NotesGroupAccordionElement.Appearance.Hovered.Options.UseBackColor = true;
            NotesGroupAccordionElement.Appearance.Hovered.Options.UseForeColor = true;
            NotesGroupAccordionElement.Appearance.Normal.BackColor = Color.FromArgb(222, 233, 239);
            NotesGroupAccordionElement.Appearance.Normal.ForeColor = Color.Black;
            NotesGroupAccordionElement.Appearance.Normal.Options.UseBackColor = true;
            NotesGroupAccordionElement.Appearance.Normal.Options.UseForeColor = true;
            NotesGroupAccordionElement.Appearance.Pressed.BackColor = Color.FromArgb(205, 230, 247);
            NotesGroupAccordionElement.Appearance.Pressed.ForeColor = Color.Black;
            NotesGroupAccordionElement.Appearance.Pressed.Options.UseBackColor = true;
            NotesGroupAccordionElement.Appearance.Pressed.Options.UseForeColor = true;
            NotesGroupAccordionElement.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { Show_Notes_Accordion_Element, accordionControlSeparator3, Add_A_New_Note_Accordion_Element, accordionControlSeparator4, View_All_Notes_Popped, accordionControlSeparator5 });
            NotesGroupAccordionElement.Expanded = true;
            NotesGroupAccordionElement.ImageOptions.Image = (Image)resources.GetObject("NotesGroupAccordionElement.ImageOptions.Image");
            NotesGroupAccordionElement.Name = "NotesGroupAccordionElement";
            NotesGroupAccordionElement.Text = "My Notes";
            // 
            // Show_Notes_Accordion_Element
            // 
            Show_Notes_Accordion_Element.Appearance.Default.Font = new Font("Tahoma", 10.2F);
            Show_Notes_Accordion_Element.Appearance.Default.ForeColor = Color.White;
            Show_Notes_Accordion_Element.Appearance.Default.Options.UseFont = true;
            Show_Notes_Accordion_Element.Appearance.Default.Options.UseForeColor = true;
            Show_Notes_Accordion_Element.Appearance.Hovered.BackColor = Color.FromArgb(205, 230, 247);
            Show_Notes_Accordion_Element.Appearance.Hovered.ForeColor = Color.Black;
            Show_Notes_Accordion_Element.Appearance.Hovered.Options.UseBackColor = true;
            Show_Notes_Accordion_Element.Appearance.Hovered.Options.UseForeColor = true;
            Show_Notes_Accordion_Element.Appearance.Normal.BackColor = Color.FromArgb(222, 233, 239);
            Show_Notes_Accordion_Element.Appearance.Normal.ForeColor = Color.Black;
            Show_Notes_Accordion_Element.Appearance.Normal.Options.UseBackColor = true;
            Show_Notes_Accordion_Element.Appearance.Normal.Options.UseForeColor = true;
            Show_Notes_Accordion_Element.Appearance.Pressed.BackColor = Color.FromArgb(205, 230, 247);
            Show_Notes_Accordion_Element.Appearance.Pressed.ForeColor = Color.Black;
            Show_Notes_Accordion_Element.Appearance.Pressed.Options.UseBackColor = true;
            Show_Notes_Accordion_Element.Appearance.Pressed.Options.UseForeColor = true;
            Show_Notes_Accordion_Element.Name = "Show_Notes_Accordion_Element";
            Show_Notes_Accordion_Element.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            Show_Notes_Accordion_Element.Text = "Show My Notes";
            // 
            // accordionControlSeparator3
            // 
            accordionControlSeparator3.Name = "accordionControlSeparator3";
            // 
            // Add_A_New_Note_Accordion_Element
            // 
            Add_A_New_Note_Accordion_Element.Appearance.Default.Font = new Font("Tahoma", 10.2F);
            Add_A_New_Note_Accordion_Element.Appearance.Default.ForeColor = Color.White;
            Add_A_New_Note_Accordion_Element.Appearance.Default.Options.UseFont = true;
            Add_A_New_Note_Accordion_Element.Appearance.Default.Options.UseForeColor = true;
            Add_A_New_Note_Accordion_Element.Appearance.Hovered.BackColor = Color.FromArgb(205, 230, 247);
            Add_A_New_Note_Accordion_Element.Appearance.Hovered.ForeColor = Color.Black;
            Add_A_New_Note_Accordion_Element.Appearance.Hovered.Options.UseBackColor = true;
            Add_A_New_Note_Accordion_Element.Appearance.Hovered.Options.UseForeColor = true;
            Add_A_New_Note_Accordion_Element.Appearance.Normal.BackColor = Color.FromArgb(222, 233, 239);
            Add_A_New_Note_Accordion_Element.Appearance.Normal.ForeColor = Color.Black;
            Add_A_New_Note_Accordion_Element.Appearance.Normal.Options.UseBackColor = true;
            Add_A_New_Note_Accordion_Element.Appearance.Normal.Options.UseForeColor = true;
            Add_A_New_Note_Accordion_Element.Appearance.Pressed.BackColor = Color.FromArgb(205, 230, 247);
            Add_A_New_Note_Accordion_Element.Appearance.Pressed.ForeColor = Color.Black;
            Add_A_New_Note_Accordion_Element.Appearance.Pressed.Options.UseBackColor = true;
            Add_A_New_Note_Accordion_Element.Appearance.Pressed.Options.UseForeColor = true;
            Add_A_New_Note_Accordion_Element.Name = "Add_A_New_Note_Accordion_Element";
            Add_A_New_Note_Accordion_Element.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            Add_A_New_Note_Accordion_Element.Text = "Add A New Note";
            // 
            // accordionControlSeparator4
            // 
            accordionControlSeparator4.Name = "accordionControlSeparator4";
            // 
            // View_All_Notes_Popped
            // 
            View_All_Notes_Popped.Appearance.Default.Font = new Font("Tahoma", 10.2F);
            View_All_Notes_Popped.Appearance.Default.ForeColor = Color.White;
            View_All_Notes_Popped.Appearance.Default.Options.UseFont = true;
            View_All_Notes_Popped.Appearance.Default.Options.UseForeColor = true;
            View_All_Notes_Popped.Appearance.Hovered.BackColor = Color.FromArgb(205, 230, 247);
            View_All_Notes_Popped.Appearance.Hovered.ForeColor = Color.Black;
            View_All_Notes_Popped.Appearance.Hovered.Options.UseBackColor = true;
            View_All_Notes_Popped.Appearance.Hovered.Options.UseForeColor = true;
            View_All_Notes_Popped.Appearance.Normal.BackColor = Color.FromArgb(222, 233, 239);
            View_All_Notes_Popped.Appearance.Normal.ForeColor = Color.Black;
            View_All_Notes_Popped.Appearance.Normal.Options.UseBackColor = true;
            View_All_Notes_Popped.Appearance.Normal.Options.UseForeColor = true;
            View_All_Notes_Popped.Appearance.Pressed.BackColor = Color.FromArgb(205, 230, 247);
            View_All_Notes_Popped.Appearance.Pressed.ForeColor = Color.Black;
            View_All_Notes_Popped.Appearance.Pressed.Options.UseBackColor = true;
            View_All_Notes_Popped.Appearance.Pressed.Options.UseForeColor = true;
            View_All_Notes_Popped.Name = "View_All_Notes_Popped";
            View_All_Notes_Popped.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            View_All_Notes_Popped.Text = "View All Notes Popped";
            View_All_Notes_Popped.Click += View_All_Notes_Popped_Click;
            // 
            // accordionControlSeparator5
            // 
            accordionControlSeparator5.Name = "accordionControlSeparator5";
            // 
            // accordionControlSeparator1
            // 
            accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // LogoutAccordionElement
            // 
            LogoutAccordionElement.Appearance.Default.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogoutAccordionElement.Appearance.Default.ForeColor = Color.White;
            LogoutAccordionElement.Appearance.Default.Options.UseFont = true;
            LogoutAccordionElement.Appearance.Default.Options.UseForeColor = true;
            LogoutAccordionElement.Appearance.Hovered.BackColor = Color.FromArgb(205, 230, 247);
            LogoutAccordionElement.Appearance.Hovered.ForeColor = Color.Black;
            LogoutAccordionElement.Appearance.Hovered.Options.UseBackColor = true;
            LogoutAccordionElement.Appearance.Hovered.Options.UseForeColor = true;
            LogoutAccordionElement.Appearance.Normal.BackColor = Color.FromArgb(222, 233, 239);
            LogoutAccordionElement.Appearance.Normal.ForeColor = Color.Black;
            LogoutAccordionElement.Appearance.Normal.Options.UseBackColor = true;
            LogoutAccordionElement.Appearance.Normal.Options.UseForeColor = true;
            LogoutAccordionElement.Appearance.Pressed.BackColor = Color.FromArgb(205, 230, 247);
            LogoutAccordionElement.Appearance.Pressed.ForeColor = Color.Black;
            LogoutAccordionElement.Appearance.Pressed.Options.UseBackColor = true;
            LogoutAccordionElement.Appearance.Pressed.Options.UseForeColor = true;
            LogoutAccordionElement.ImageOptions.Image = (Image)resources.GetObject("LogoutAccordionElement.ImageOptions.Image");
            LogoutAccordionElement.Name = "LogoutAccordionElement";
            LogoutAccordionElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            LogoutAccordionElement.Text = "Logout";
            LogoutAccordionElement.Click += LogoutAccordionElement_Click;
            // 
            // accordionControlSeparator2
            // 
            accordionControlSeparator2.Name = "accordionControlSeparator2";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1010, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importNoteToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // importNoteToolStripMenuItem
            // 
            importNoteToolStripMenuItem.Name = "importNoteToolStripMenuItem";
            importNoteToolStripMenuItem.Size = new Size(180, 22);
            importNoteToolStripMenuItem.Text = "Import Note";
            importNoteToolStripMenuItem.Click += importNoteToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // MDI_Panel
            // 
            MDI_Panel.BackColor = Color.White;
            MDI_Panel.Dock = DockStyle.Fill;
            MDI_Panel.Location = new Point(260, 24);
            MDI_Panel.Name = "MDI_Panel";
            MDI_Panel.Size = new Size(750, 750);
            MDI_Panel.TabIndex = 2;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 774);
            Controls.Add(MDI_Panel);
            Controls.Add(accordionControl1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Main_Form";
            Load += Notify_Load;
            ((System.ComponentModel.ISupportInitialize)accordionControl1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement NotesGroupAccordionElement;

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Panel MDI_Panel;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Show_Notes_Accordion_Element;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Add_A_New_Note_Accordion_Element;
        private DevExpress.XtraBars.Navigation.AccordionControlElement View_All_Notes_Popped;
        private ToolStripMenuItem importNoteToolStripMenuItem;
        private DevExpress.XtraBars.Navigation.AccordionControlElement LogoutAccordionElement;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator3;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator4;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator5;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator2;
    }
}
