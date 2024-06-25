namespace EmployeeClass
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
            input_FirstName = new TextBox();
            input_LastName = new TextBox();
            input_Position = new TextBox();
            button_DisplayInfo = new Button();
            output_EmployeeInfo = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 101);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 174);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 247);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 2;
            label3.Text = "Position:";
            // 
            // input_FirstName
            // 
            input_FirstName.Location = new Point(215, 97);
            input_FirstName.Name = "input_FirstName";
            input_FirstName.Size = new Size(350, 33);
            input_FirstName.TabIndex = 1;
            // 
            // input_LastName
            // 
            input_LastName.Location = new Point(215, 170);
            input_LastName.Name = "input_LastName";
            input_LastName.Size = new Size(350, 33);
            input_LastName.TabIndex = 2;
            // 
            // input_Position
            // 
            input_Position.Location = new Point(215, 243);
            input_Position.Name = "input_Position";
            input_Position.Size = new Size(350, 33);
            input_Position.TabIndex = 3;
            // 
            // button_DisplayInfo
            // 
            button_DisplayInfo.Location = new Point(73, 315);
            button_DisplayInfo.Name = "button_DisplayInfo";
            button_DisplayInfo.Size = new Size(492, 61);
            button_DisplayInfo.TabIndex = 4;
            button_DisplayInfo.Text = "Display Employee Information";
            button_DisplayInfo.UseVisualStyleBackColor = true;
            button_DisplayInfo.Click += button_DisplayInfo_Click;
            // 
            // output_EmployeeInfo
            // 
            output_EmployeeInfo.BorderStyle = BorderStyle.FixedSingle;
            output_EmployeeInfo.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            output_EmployeeInfo.Location = new Point(73, 404);
            output_EmployeeInfo.Name = "output_EmployeeInfo";
            output_EmployeeInfo.Size = new Size(492, 63);
            output_EmployeeInfo.TabIndex = 7;
            output_EmployeeInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 576);
            Controls.Add(output_EmployeeInfo);
            Controls.Add(button_DisplayInfo);
            Controls.Add(input_Position);
            Controls.Add(input_LastName);
            Controls.Add(input_FirstName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Employee Class";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox input_FirstName;
        private TextBox input_LastName;
        private TextBox input_Position;
        private Button button_DisplayInfo;
        private Label output_EmployeeInfo;
    }
}
