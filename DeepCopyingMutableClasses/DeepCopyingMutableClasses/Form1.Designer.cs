namespace DeepCopyingMutableClasses
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
            input_StreetName = new TextBox();
            input_City = new TextBox();
            input_HouseNumber = new TextBox();
            input_Name = new TextBox();
            button_ModifyAddress = new Button();
            button_CreatePerson = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            output_OrigPerson = new Label();
            label7 = new Label();
            output_CopiedPerson = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(input_StreetName);
            groupBox1.Controls.Add(input_City);
            groupBox1.Controls.Add(input_HouseNumber);
            groupBox1.Controls.Add(input_Name);
            groupBox1.Controls.Add(button_ModifyAddress);
            groupBox1.Controls.Add(button_CreatePerson);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(32, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(436, 452);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter Info";
            // 
            // input_StreetName
            // 
            input_StreetName.Location = new Point(164, 159);
            input_StreetName.Name = "input_StreetName";
            input_StreetName.Size = new Size(250, 33);
            input_StreetName.TabIndex = 3;
            // 
            // input_City
            // 
            input_City.Location = new Point(164, 213);
            input_City.Name = "input_City";
            input_City.Size = new Size(250, 33);
            input_City.TabIndex = 4;
            // 
            // input_HouseNumber
            // 
            input_HouseNumber.Location = new Point(164, 105);
            input_HouseNumber.Name = "input_HouseNumber";
            input_HouseNumber.Size = new Size(250, 33);
            input_HouseNumber.TabIndex = 2;
            // 
            // input_Name
            // 
            input_Name.Location = new Point(164, 51);
            input_Name.Name = "input_Name";
            input_Name.Size = new Size(250, 33);
            input_Name.TabIndex = 1;
            // 
            // button_ModifyAddress
            // 
            button_ModifyAddress.Location = new Point(12, 356);
            button_ModifyAddress.Name = "button_ModifyAddress";
            button_ModifyAddress.Size = new Size(402, 62);
            button_ModifyAddress.TabIndex = 6;
            button_ModifyAddress.Text = "Modify Adress";
            button_ModifyAddress.UseVisualStyleBackColor = true;
            button_ModifyAddress.Click += button_ModifyAddress_Click;
            // 
            // button_CreatePerson
            // 
            button_CreatePerson.Location = new Point(12, 276);
            button_CreatePerson.Name = "button_CreatePerson";
            button_CreatePerson.Size = new Size(402, 62);
            button_CreatePerson.TabIndex = 5;
            button_CreatePerson.Text = "Create Person";
            button_CreatePerson.UseVisualStyleBackColor = true;
            button_CreatePerson.Click += button_CreatePerson_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 217);
            label4.Name = "label4";
            label4.Size = new Size(44, 25);
            label4.TabIndex = 3;
            label4.Text = "City";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 163);
            label3.Name = "label3";
            label3.Size = new Size(115, 25);
            label3.TabIndex = 2;
            label3.Text = "Street Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 109);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 1;
            label2.Text = "House Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(510, 57);
            label5.Name = "label5";
            label5.Size = new Size(142, 25);
            label5.TabIndex = 1;
            label5.Text = "Original Person";
            // 
            // output_OrigPerson
            // 
            output_OrigPerson.BackColor = SystemColors.ActiveCaption;
            output_OrigPerson.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            output_OrigPerson.ForeColor = SystemColors.ButtonHighlight;
            output_OrigPerson.Location = new Point(510, 95);
            output_OrigPerson.Name = "output_OrigPerson";
            output_OrigPerson.Size = new Size(556, 133);
            output_OrigPerson.TabIndex = 1;
            output_OrigPerson.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(510, 278);
            label7.Name = "label7";
            label7.Size = new Size(134, 25);
            label7.TabIndex = 1;
            label7.Text = "Copied Person";
            // 
            // output_CopiedPerson
            // 
            output_CopiedPerson.BackColor = Color.MistyRose;
            output_CopiedPerson.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            output_CopiedPerson.ForeColor = SystemColors.ActiveCaptionText;
            output_CopiedPerson.Location = new Point(510, 316);
            output_CopiedPerson.Name = "output_CopiedPerson";
            output_CopiedPerson.Size = new Size(556, 133);
            output_CopiedPerson.TabIndex = 1;
            output_CopiedPerson.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 526);
            Controls.Add(output_CopiedPerson);
            Controls.Add(label7);
            Controls.Add(output_OrigPerson);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Deep Copying Mtable Class";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button_CreatePerson;
        private TextBox input_StreetName;
        private TextBox input_City;
        private TextBox input_HouseNumber;
        private TextBox input_Name;
        private Button button_ModifyAddress;
        private Label label5;
        private Label output_OrigPerson;
        private Label label7;
        private Label output_CopiedPerson;
    }
}
