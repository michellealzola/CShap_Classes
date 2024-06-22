namespace StudentGrades
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            input_StudentID = new TextBox();
            input_Name = new TextBox();
            input_Grade = new TextBox();
            button_AddStudent = new Button();
            listBox_StudentInfo = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_AddStudent);
            groupBox1.Controls.Add(input_Grade);
            groupBox1.Controls.Add(input_Name);
            groupBox1.Controls.Add(input_StudentID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(537, 317);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Student";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 43);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 0;
            label1.Text = "Student ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 103);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 163);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 2;
            label3.Text = "Grade:";
            // 
            // input_StudentID
            // 
            input_StudentID.BorderStyle = BorderStyle.FixedSingle;
            input_StudentID.Location = new Point(171, 39);
            input_StudentID.Name = "input_StudentID";
            input_StudentID.Size = new Size(325, 33);
            input_StudentID.TabIndex = 1;
            // 
            // input_Name
            // 
            input_Name.BorderStyle = BorderStyle.FixedSingle;
            input_Name.Location = new Point(171, 99);
            input_Name.Name = "input_Name";
            input_Name.Size = new Size(325, 33);
            input_Name.TabIndex = 2;
            // 
            // input_Grade
            // 
            input_Grade.BorderStyle = BorderStyle.FixedSingle;
            input_Grade.Location = new Point(171, 159);
            input_Grade.Name = "input_Grade";
            input_Grade.Size = new Size(325, 33);
            input_Grade.TabIndex = 3;
            // 
            // button_AddStudent
            // 
            button_AddStudent.Location = new Point(30, 240);
            button_AddStudent.Name = "button_AddStudent";
            button_AddStudent.Size = new Size(466, 47);
            button_AddStudent.TabIndex = 4;
            button_AddStudent.Text = "Add Student";
            button_AddStudent.UseVisualStyleBackColor = true;
            button_AddStudent.Click += button_AddStudent_Click;
            // 
            // listBox_StudentInfo
            // 
            listBox_StudentInfo.FormattingEnabled = true;
            listBox_StudentInfo.ItemHeight = 25;
            listBox_StudentInfo.Location = new Point(560, 25);
            listBox_StudentInfo.Name = "listBox_StudentInfo";
            listBox_StudentInfo.Size = new Size(336, 304);
            listBox_StudentInfo.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 348);
            Controls.Add(listBox_StudentInfo);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form1";
            Text = "Student Grades";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox input_Grade;
        private TextBox input_Name;
        private TextBox input_StudentID;
        private Button button_AddStudent;
        private ListBox listBox_StudentInfo;
    }
}
