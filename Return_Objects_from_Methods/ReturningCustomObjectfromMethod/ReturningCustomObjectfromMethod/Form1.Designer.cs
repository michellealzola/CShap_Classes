namespace ReturningCustomObjectfromMethod
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            input_Name = new TextBox();
            input_Age = new TextBox();
            input_Email = new TextBox();
            button_CreatePerson = new Button();
            listBox_Person = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 42);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 103);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 1;
            label2.Text = "Enter Age:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 164);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 2;
            label3.Text = "Enter Email:";
            // 
            // input_Name
            // 
            input_Name.Location = new Point(196, 38);
            input_Name.Name = "input_Name";
            input_Name.Size = new Size(350, 33);
            input_Name.TabIndex = 1;
            // 
            // input_Age
            // 
            input_Age.Location = new Point(196, 99);
            input_Age.Name = "input_Age";
            input_Age.Size = new Size(350, 33);
            input_Age.TabIndex = 2;
            // 
            // input_Email
            // 
            input_Email.Location = new Point(196, 160);
            input_Email.Name = "input_Email";
            input_Email.Size = new Size(350, 33);
            input_Email.TabIndex = 3;
            // 
            // button_CreatePerson
            // 
            button_CreatePerson.Location = new Point(47, 225);
            button_CreatePerson.Name = "button_CreatePerson";
            button_CreatePerson.Size = new Size(499, 64);
            button_CreatePerson.TabIndex = 6;
            button_CreatePerson.Text = "Create Person";
            button_CreatePerson.UseVisualStyleBackColor = true;
            button_CreatePerson.Click += button_CreatePerson_Click;
            // 
            // listBox_Person
            // 
            listBox_Person.FormattingEnabled = true;
            listBox_Person.ItemHeight = 25;
            listBox_Person.Location = new Point(47, 315);
            listBox_Person.Name = "listBox_Person";
            listBox_Person.Size = new Size(499, 404);
            listBox_Person.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 750);
            Controls.Add(listBox_Person);
            Controls.Add(button_CreatePerson);
            Controls.Add(input_Email);
            Controls.Add(input_Age);
            Controls.Add(input_Name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form1";
            Text = "Returning a Custom Object from a Method";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox input_Name;
        private TextBox input_Age;
        private TextBox input_Email;
        private Button button_CreatePerson;
        private ListBox listBox_Person;
    }
}
