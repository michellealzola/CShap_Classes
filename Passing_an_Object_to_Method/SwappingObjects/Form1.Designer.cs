namespace SwappingObjects
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
            input_Age1 = new TextBox();
            input_Name1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            input_Age2 = new TextBox();
            input_Name2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            button_Exit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(input_Age1);
            groupBox1.Controls.Add(input_Name1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(393, 177);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Person 1:";
            // 
            // input_Age1
            // 
            input_Age1.BorderStyle = BorderStyle.FixedSingle;
            input_Age1.Location = new Point(106, 105);
            input_Age1.Name = "input_Age1";
            input_Age1.Size = new Size(248, 33);
            input_Age1.TabIndex = 1;
            // 
            // input_Name1
            // 
            input_Name1.BorderStyle = BorderStyle.FixedSingle;
            input_Name1.Location = new Point(106, 57);
            input_Name1.Name = "input_Name1";
            input_Name1.Size = new Size(248, 33);
            input_Name1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 109);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 0;
            label2.Text = "Age:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 61);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(input_Age2);
            groupBox2.Controls.Add(input_Name2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(411, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(393, 177);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Person 2:";
            // 
            // input_Age2
            // 
            input_Age2.BorderStyle = BorderStyle.FixedSingle;
            input_Age2.Location = new Point(106, 105);
            input_Age2.Name = "input_Age2";
            input_Age2.Size = new Size(248, 33);
            input_Age2.TabIndex = 1;
            // 
            // input_Name2
            // 
            input_Name2.BorderStyle = BorderStyle.FixedSingle;
            input_Name2.Location = new Point(106, 57);
            input_Name2.Name = "input_Name2";
            input_Name2.Size = new Size(248, 33);
            input_Name2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 109);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 0;
            label3.Text = "Age:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 61);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 0;
            label4.Text = "Name:";
            // 
            // button1
            // 
            button1.Location = new Point(12, 198);
            button1.Name = "button1";
            button1.Size = new Size(792, 58);
            button1.TabIndex = 1;
            button1.Text = "Swap Persons";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(12, 272);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(792, 379);
            listBox1.TabIndex = 2;
            // 
            // button_Exit
            // 
            button_Exit.Location = new Point(11, 666);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(792, 58);
            button_Exit.TabIndex = 1;
            button_Exit.Text = "E&xit";
            button_Exit.UseVisualStyleBackColor = true;
            button_Exit.Click += button_Exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 750);
            Controls.Add(listBox1);
            Controls.Add(button_Exit);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Swapping Objects";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox input_Age1;
        private TextBox input_Name1;
        private GroupBox groupBox2;
        private TextBox input_Age2;
        private TextBox input_Name2;
        private Label label3;
        private Label label4;
        private Button button1;
        private ListBox listBox1;
        private Button button_Exit;
    }
}
