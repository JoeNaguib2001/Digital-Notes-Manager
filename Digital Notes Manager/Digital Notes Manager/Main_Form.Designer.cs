namespace Digital_Notes_Manager
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            NotesGroupAccordionElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            View_All_Notes_Popped = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            Show_Notes_Accordion_Element = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            Add_A_New_Note_Accordion_Element = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlSeparator5 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            Report_ControlElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            Gantt_Chart_Element = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            Logout_AccordionElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlSeparator2 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            importNoteToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            MDI_Panel = new Panel();
            NotificationPanel = new Panel();
            notificationBell1 = new Customs.NotificationBell();
            notifyIcon1 = new NotifyIcon(components);
            GreatDocker = new Panel();
            ((System.ComponentModel.ISupportInitialize)accordionControl1).BeginInit();
            menuStrip1.SuspendLayout();
            NotificationPanel.SuspendLayout();
            GreatDocker.SuspendLayout();
            SuspendLayout();
            // 
            // accordionControl1
            // 
            accordionControl1.Appearance.AccordionControl.BackColor = Color.FromArgb(222, 233, 239);
            accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
            accordionControl1.Dock = DockStyle.Left;
            accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { NotesGroupAccordionElement, accordionControlSeparator1, Logout_AccordionElement, accordionControlSeparator2 });
            accordionControl1.Location = new Point(0, 24);
            accordionControl1.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            accordionControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            accordionControl1.Name = "accordionControl1";
            accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            accordionControl1.Size = new Size(250, 842);
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
            NotesGroupAccordionElement.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { View_All_Notes_Popped, Show_Notes_Accordion_Element, Add_A_New_Note_Accordion_Element, accordionControlSeparator5, Report_ControlElement, Gantt_Chart_Element });
            NotesGroupAccordionElement.Expanded = true;
            NotesGroupAccordionElement.ImageOptions.Image = (Image)resources.GetObject("NotesGroupAccordionElement.ImageOptions.Image");
            NotesGroupAccordionElement.Name = "NotesGroupAccordionElement";
            NotesGroupAccordionElement.Text = "My Notes";
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
            // accordionControlSeparator5
            // 
            accordionControlSeparator5.Name = "accordionControlSeparator5";
            // 
            // Report_ControlElement
            // 
            Report_ControlElement.Appearance.Default.Font = new Font("Tahoma", 10.2F);
            Report_ControlElement.Appearance.Default.ForeColor = Color.White;
            Report_ControlElement.Appearance.Default.Options.UseFont = true;
            Report_ControlElement.Appearance.Default.Options.UseForeColor = true;
            Report_ControlElement.Appearance.Hovered.BackColor = Color.FromArgb(205, 230, 247);
            Report_ControlElement.Appearance.Hovered.ForeColor = Color.Black;
            Report_ControlElement.Appearance.Hovered.Options.UseBackColor = true;
            Report_ControlElement.Appearance.Hovered.Options.UseForeColor = true;
            Report_ControlElement.Appearance.Normal.BackColor = Color.FromArgb(222, 233, 239);
            Report_ControlElement.Appearance.Normal.ForeColor = Color.Black;
            Report_ControlElement.Appearance.Normal.Options.UseBackColor = true;
            Report_ControlElement.Appearance.Normal.Options.UseForeColor = true;
            Report_ControlElement.Appearance.Pressed.BackColor = Color.FromArgb(205, 230, 247);
            Report_ControlElement.Appearance.Pressed.ForeColor = Color.Black;
            Report_ControlElement.Appearance.Pressed.Options.UseBackColor = true;
            Report_ControlElement.Appearance.Pressed.Options.UseForeColor = true;
            Report_ControlElement.Name = "Report_ControlElement";
            Report_ControlElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            Report_ControlElement.Text = "Report";
            // 
            // Gantt_Chart_Element
            // 
             Gantt_Chart_Element.Appearance.Default.Font = new Font("Tahoma", 10.2F);
             Gantt_Chart_Element.Appearance.Default.ForeColor = Color.White;
             Gantt_Chart_Element.Appearance.Default.Options.UseFont = true;
             Gantt_Chart_Element.Appearance.Default.Options.UseForeColor = true;
             Gantt_Chart_Element.Appearance.Hovered.BackColor = Color.FromArgb(205, 230, 247);
             Gantt_Chart_Element.Appearance.Hovered.ForeColor = Color.Black;
             Gantt_Chart_Element.Appearance.Hovered.Options.UseBackColor = true;
             Gantt_Chart_Element.Appearance.Hovered.Options.UseForeColor = true;
             Gantt_Chart_Element.Appearance.Normal.BackColor = Color.FromArgb(222, 233, 239);
             Gantt_Chart_Element.Appearance.Normal.ForeColor = Color.Black;
             Gantt_Chart_Element.Appearance.Normal.Options.UseBackColor = true;
             Gantt_Chart_Element.Appearance.Normal.Options.UseForeColor = true;
             Gantt_Chart_Element.Appearance.Pressed.BackColor = Color.FromArgb(205, 230, 247);
             Gantt_Chart_Element.Appearance.Pressed.ForeColor = Color.Black;
             Gantt_Chart_Element.Appearance.Pressed.Options.UseBackColor = true;
             Gantt_Chart_Element.Appearance.Pressed.Options.UseForeColor = true;
             Gantt_Chart_Element.Name = "Gantt_Chart_Element";
             Gantt_Chart_Element.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
             Gantt_Chart_Element.Text = "Gantt";
            // 
            // accordionControlSeparator1
            // 
            accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // Logout_AccordionElement
            // 
            Logout_AccordionElement.Appearance.Default.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Logout_AccordionElement.Appearance.Default.ForeColor = Color.White;
            Logout_AccordionElement.Appearance.Default.Options.UseFont = true;
            Logout_AccordionElement.Appearance.Default.Options.UseForeColor = true;
            Logout_AccordionElement.Appearance.Hovered.BackColor = Color.FromArgb(205, 230, 247);
            Logout_AccordionElement.Appearance.Hovered.ForeColor = Color.Black;
            Logout_AccordionElement.Appearance.Hovered.Options.UseBackColor = true;
            Logout_AccordionElement.Appearance.Hovered.Options.UseForeColor = true;
            Logout_AccordionElement.Appearance.Normal.BackColor = Color.FromArgb(222, 233, 239);
            Logout_AccordionElement.Appearance.Normal.ForeColor = Color.Black;
            Logout_AccordionElement.Appearance.Normal.Options.UseBackColor = true;
            Logout_AccordionElement.Appearance.Normal.Options.UseForeColor = true;
            Logout_AccordionElement.Appearance.Pressed.BackColor = Color.FromArgb(205, 230, 247);
            Logout_AccordionElement.Appearance.Pressed.ForeColor = Color.Black;
            Logout_AccordionElement.Appearance.Pressed.Options.UseBackColor = true;
            Logout_AccordionElement.Appearance.Pressed.Options.UseForeColor = true;
            Logout_AccordionElement.ImageOptions.Image = (Image)resources.GetObject("Logout_AccordionElement.ImageOptions.Image");
            Logout_AccordionElement.Name = "Logout_AccordionElement";
            Logout_AccordionElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            Logout_AccordionElement.Text = "Logout";
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
            menuStrip1.Size = new Size(1461, 24);
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
            importNoteToolStripMenuItem.Size = new Size(139, 22);
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
            MDI_Panel.Location = new Point(0, 42);
            MDI_Panel.Name = "MDI_Panel";
            MDI_Panel.Size = new Size(1211, 800);
            MDI_Panel.TabIndex = 2;
            // 
            // NotificationPanel
            // 
            NotificationPanel.Controls.Add(notificationBell1);
            NotificationPanel.Dock = DockStyle.Top;
            NotificationPanel.Location = new Point(0, 0);
            NotificationPanel.Name = "NotificationPanel";
            NotificationPanel.Size = new Size(1211, 42);
            NotificationPanel.TabIndex = 4;
            // 
            // notificationBell1
            // 
            notificationBell1.Anchor = AnchorStyles.None;
            notificationBell1.Location = new Point(1138, 13);
            notificationBell1.Name = "notificationBell1";
            notificationBell1.NotificationCount = 0;
            notificationBell1.Size = new Size(24, 23);
            notificationBell1.TabIndex = 0;
            notificationBell1.Text = "notificationBell1";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // GreatDocker
            // 
            GreatDocker.Controls.Add(MDI_Panel);
            GreatDocker.Controls.Add(NotificationPanel);
            GreatDocker.Dock = DockStyle.Fill;
            GreatDocker.Location = new Point(250, 24);
            GreatDocker.Name = "GreatDocker";
            GreatDocker.Size = new Size(1211, 842);
            GreatDocker.TabIndex = 6;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1461, 866);
            Controls.Add(GreatDocker);
            Controls.Add(accordionControl1);
            Controls.Add(menuStrip1);
            IconOptions.Icon = (Icon)resources.GetObject("Main_Form.IconOptions.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Main_Form";
            Load += Notify_Load;
            ((System.ComponentModel.ISupportInitialize)accordionControl1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            NotificationPanel.ResumeLayout(false);
            GreatDocker.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement NotesGroupAccordionElement;

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Show_Notes_Accordion_Element;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Add_A_New_Note_Accordion_Element;
        private DevExpress.XtraBars.Navigation.AccordionControlElement View_All_Notes_Popped;
        private ToolStripMenuItem importNoteToolStripMenuItem;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Logout_AccordionElement;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator5;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Report_ControlElement;
        private Panel NotificationPanel;
        private NotifyIcon notifyIcon1;
        private Customs.NotificationBell notificationBell1;
        private Panel GreatDocker;
        public Panel MDI_Panel;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Gantt_Chart_Element;
    }
}
