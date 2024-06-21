namespace DistanceCalculation
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
            input_x = new TextBox();
            input_y = new TextBox();
            button1 = new Button();
            output_distance = new Label();
            button_Exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(30, 36);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter Point 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(30, 102);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 0;
            label2.Text = "Enter Point 2:";
            // 
            // input_x
            // 
            input_x.BorderStyle = BorderStyle.FixedSingle;
            input_x.Location = new System.Drawing.Point(179, 32);
            input_x.Name = "input_x";
            input_x.Size = new Size(270, 33);
            input_x.TabIndex = 1;
            // 
            // input_y
            // 
            input_y.BorderStyle = BorderStyle.FixedSingle;
            input_y.Location = new System.Drawing.Point(179, 98);
            input_y.Name = "input_y";
            input_y.Size = new Size(270, 33);
            input_y.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(30, 166);
            button1.Name = "button1";
            button1.Size = new Size(419, 53);
            button1.TabIndex = 2;
            button1.Text = "Calculate Distance";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // output_distance
            // 
            output_distance.BorderStyle = BorderStyle.FixedSingle;
            output_distance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            output_distance.Location = new System.Drawing.Point(30, 239);
            output_distance.Name = "output_distance";
            output_distance.Size = new Size(419, 60);
            output_distance.TabIndex = 3;
            output_distance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_Exit
            // 
            button_Exit.Location = new System.Drawing.Point(30, 326);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(419, 53);
            button_Exit.TabIndex = 2;
            button_Exit.Text = "E&xit";
            button_Exit.UseVisualStyleBackColor = true;
            button_Exit.Click += button_Exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 406);
            Controls.Add(output_distance);
            Controls.Add(button_Exit);
            Controls.Add(button1);
            Controls.Add(input_y);
            Controls.Add(input_x);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Distance Calculation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox input_x;
        private TextBox input_y;
        private Button button1;
        private Label output_distance;
        private Button button_Exit;
    }
}
