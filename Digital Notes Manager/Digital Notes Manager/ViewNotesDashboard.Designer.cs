namespace Test
{
    partial class ViewNotesDashboard
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
            components = new System.ComponentModel.Container();
            fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            NotesPanel = new System.Windows.Forms.Panel();
            CategoryPanel = new System.Windows.Forms.Panel();
            fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(components);
            barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            fluentDesignFormContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fluentFormDefaultManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accordionControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).BeginInit();
            SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            fluentDesignFormContainer1.Controls.Add(tableLayoutPanel1);
            fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            fluentDesignFormContainer1.Location = new System.Drawing.Point(60, 39);
            fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            fluentDesignFormContainer1.Size = new System.Drawing.Size(1140, 761);
            fluentDesignFormContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(NotesPanel, 0, 3);
            tableLayoutPanel1.Controls.Add(CategoryPanel, 0, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.03919F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.96081F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1140, 761);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(3, 297);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(1134, 32);
            label2.TabIndex = 1;
            label2.Text = "My Notes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(3, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(1134, 32);
            label3.TabIndex = 3;
            label3.Text = "My Categories";
            // 
            // NotesPanel
            // 
            NotesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            NotesPanel.Location = new System.Drawing.Point(3, 332);
            NotesPanel.Name = "NotesPanel";
            NotesPanel.Size = new System.Drawing.Size(1134, 426);
            NotesPanel.TabIndex = 3;
            // 
            // CategoryPanel
            // 
            CategoryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            CategoryPanel.Location = new System.Drawing.Point(3, 35);
            CategoryPanel.Name = "CategoryPanel";
            CategoryPanel.Size = new System.Drawing.Size(1134, 259);
            CategoryPanel.TabIndex = 2;
            // 
            // fluentFormDefaultManager1
            // 
            fluentFormDefaultManager1.Form = this;
            fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barHeaderItem1 });
            fluentFormDefaultManager1.MaxItemId = 1;
            // 
            // barHeaderItem1
            // 
            barHeaderItem1.Caption = "My Notes";
            barHeaderItem1.Id = 0;
            barHeaderItem1.Name = "barHeaderItem1";
            // 
            // accordionControl1
            // 
            accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlElement1 });
            accordionControl1.Location = new System.Drawing.Point(0, 39);
            accordionControl1.Name = "accordionControl1";
            accordionControl1.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;
            accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            accordionControl1.Size = new System.Drawing.Size(60, 761);
            accordionControl1.TabIndex = 1;
            accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            accordionControlElement1.Expanded = true;
            accordionControlElement1.Name = "accordionControlElement1";
            accordionControlElement1.Text = "Categories";
            // 
            // fluentDesignFormControl1
            // 
            fluentDesignFormControl1.FluentDesignForm = this;
            fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barHeaderItem1 });
            fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            fluentDesignFormControl1.Manager = fluentFormDefaultManager1;
            fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            fluentDesignFormControl1.Size = new System.Drawing.Size(1200, 39);
            fluentDesignFormControl1.TabIndex = 4;
            fluentDesignFormControl1.TabStop = false;
            fluentDesignFormControl1.Text = "View All Notes";
            fluentDesignFormControl1.TitleItemLinks.Add(barHeaderItem1);
            // 
            // ViewNotesDashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1200, 800);
            ControlContainer = fluentDesignFormContainer1;
            Controls.Add(fluentDesignFormContainer1);
            Controls.Add(accordionControl1);
            Controls.Add(fluentDesignFormControl1);
            FluentDesignFormControl = fluentDesignFormControl1;
            Name = "ViewNotesDashboard";
            NavigationControl = accordionControl1;
            Text = "View All Notes";
            fluentDesignFormContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fluentFormDefaultManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)accordionControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel NotesPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel CategoryPanel;
        private System.Windows.Forms.Label label3;
    }
}

