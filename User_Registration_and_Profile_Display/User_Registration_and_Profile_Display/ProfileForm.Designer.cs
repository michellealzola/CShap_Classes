namespace User_Registration_and_Profile_Display
{
    partial class ProfileForm
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
            output_Password = new Label();
            output_Email = new Label();
            output_Name = new Label();
            button_Exit = new Button();
            SuspendLayout();
            // 
            // output_Password
            // 
            output_Password.BorderStyle = BorderStyle.FixedSingle;
            output_Password.Font = new Font("Segoe UI", 15.75F);
            output_Password.Location = new Point(52, 151);
            output_Password.Name = "output_Password";
            output_Password.Size = new Size(423, 50);
            output_Password.TabIndex = 1;
            output_Password.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // output_Email
            // 
            output_Email.BorderStyle = BorderStyle.FixedSingle;
            output_Email.Font = new Font("Segoe UI", 15.75F);
            output_Email.Location = new Point(52, 94);
            output_Email.Name = "output_Email";
            output_Email.Size = new Size(423, 50);
            output_Email.TabIndex = 2;
            output_Email.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // output_Name
            // 
            output_Name.BorderStyle = BorderStyle.FixedSingle;
            output_Name.Font = new Font("Segoe UI", 15.75F);
            output_Name.Location = new Point(52, 37);
            output_Name.Name = "output_Name";
            output_Name.Size = new Size(423, 50);
            output_Name.TabIndex = 3;
            output_Name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button_Exit
            // 
            button_Exit.Location = new Point(52, 221);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(423, 57);
            button_Exit.TabIndex = 6;
            button_Exit.Text = "E&xit";
            button_Exit.UseVisualStyleBackColor = true;
            button_Exit.Click += button_Exit_Click;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 303);
            Controls.Add(button_Exit);
            Controls.Add(output_Password);
            Controls.Add(output_Email);
            Controls.Add(output_Name);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "ProfileForm";
            Text = "Profile Form";
            ResumeLayout(false);
        }

        #endregion
        private Button button_Exit;
        protected internal Label output_Email;
        protected internal Label output_Password;
        protected internal Label output_Name;
    }
}