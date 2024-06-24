namespace User_Registration_and_Profile_Display
{
    partial class RegistrationForm
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
            input_Email = new TextBox();
            input_Password = new TextBox();
            button_DisplayUserInfo = new Button();
            button_Exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 44);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 101);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 0;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 158);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 0;
            label3.Text = "Password:";
            // 
            // input_Name
            // 
            input_Name.Location = new Point(171, 40);
            input_Name.Name = "input_Name";
            input_Name.Size = new Size(432, 33);
            input_Name.TabIndex = 1;
            // 
            // input_Email
            // 
            input_Email.Location = new Point(171, 97);
            input_Email.Name = "input_Email";
            input_Email.Size = new Size(432, 33);
            input_Email.TabIndex = 2;
            // 
            // input_Password
            // 
            input_Password.Location = new Point(171, 154);
            input_Password.Name = "input_Password";
            input_Password.Size = new Size(432, 33);
            input_Password.TabIndex = 3;
            // 
            // button_DisplayUserInfo
            // 
            button_DisplayUserInfo.Location = new Point(30, 219);
            button_DisplayUserInfo.Name = "button_DisplayUserInfo";
            button_DisplayUserInfo.Size = new Size(346, 57);
            button_DisplayUserInfo.TabIndex = 4;
            button_DisplayUserInfo.Text = "Display User Info";
            button_DisplayUserInfo.UseVisualStyleBackColor = true;
            button_DisplayUserInfo.Click += button_DisplayUserInfo_Click;
            // 
            // button_Exit
            // 
            button_Exit.Location = new Point(382, 219);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(221, 57);
            button_Exit.TabIndex = 5;
            button_Exit.Text = "E&xit";
            button_Exit.UseVisualStyleBackColor = true;
            button_Exit.Click += button_Exit_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 306);
            Controls.Add(button_Exit);
            Controls.Add(button_DisplayUserInfo);
            Controls.Add(input_Password);
            Controls.Add(input_Email);
            Controls.Add(input_Name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "RegistrationForm";
            Text = "Registration Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox input_Name;
        private TextBox input_Email;
        private TextBox input_Password;
        private Button button_DisplayUserInfo;
        private Button button_Exit;
    }
}
