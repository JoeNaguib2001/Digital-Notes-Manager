namespace Digital_Notes_Manager
{
    partial class Testing
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
            accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            dateTimePicker1 = new DateTimePicker();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)accordionControl1).BeginInit();
            SuspendLayout();
            // 
            // accordionControl1
            // 
            accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlElement1 });
            accordionControl1.Location = new Point(22, 50);
            accordionControl1.Name = "accordionControl1";
            accordionControl1.Size = new Size(260, 300);
            accordionControl1.TabIndex = 0;
            // 
            // accordionControlElement1
            // 
            accordionControlElement1.Name = "accordionControlElement1";
            accordionControlElement1.Text = "Element1";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(480, 97);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(350, 237);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(100, 96);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(513, 237);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(100, 96);
            richTextBox2.TabIndex = 3;
            richTextBox2.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(448, 370);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Testing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(accordionControl1);
            Name = "Testing";
            Text = "Testing";
            ((System.ComponentModel.ISupportInitialize)accordionControl1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DateTimePicker dateTimePicker1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button button1;
    }
}