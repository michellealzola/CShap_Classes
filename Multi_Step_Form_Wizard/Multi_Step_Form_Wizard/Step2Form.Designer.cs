namespace Multi_Step_Form_Wizard
{
    partial class Step2Form
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
            button_BackStep2 = new Button();
            output_NoAge = new Label();
            input_Age = new TextBox();
            label1 = new Label();
            button_NextStep2 = new Button();
            SuspendLayout();
            // 
            // button_BackStep2
            // 
            button_BackStep2.Location = new Point(31, 195);
            button_BackStep2.Name = "button_BackStep2";
            button_BackStep2.Size = new Size(91, 51);
            button_BackStep2.TabIndex = 7;
            button_BackStep2.Text = "Back";
            button_BackStep2.UseVisualStyleBackColor = true;
            button_BackStep2.Click += button_BackStep2_Click;
            // 
            // output_NoAge
            // 
            output_NoAge.Location = new Point(30, 141);
            output_NoAge.Name = "output_NoAge";
            output_NoAge.Size = new Size(374, 32);
            output_NoAge.TabIndex = 6;
            // 
            // input_Age
            // 
            input_Age.Location = new Point(134, 65);
            input_Age.Name = "input_Age";
            input_Age.Size = new Size(270, 33);
            input_Age.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 69);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 4;
            label1.Text = "Age:";
            // 
            // button_NextStep2
            // 
            button_NextStep2.Location = new Point(128, 195);
            button_NextStep2.Name = "button_NextStep2";
            button_NextStep2.Size = new Size(91, 51);
            button_NextStep2.TabIndex = 7;
            button_NextStep2.Text = "Next";
            button_NextStep2.UseVisualStyleBackColor = true;
            button_NextStep2.Click += button_NextStep2_Click;
            // 
            // Step2Form
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 311);
            Controls.Add(button_NextStep2);
            Controls.Add(button_BackStep2);
            Controls.Add(output_NoAge);
            Controls.Add(input_Age);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Step2Form";
            Text = "Step 2 ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_BackStep2;
        private Label output_NoAge;
        private TextBox input_Age;
        private Label label1;
        private Button button_NextStep2;
    }
}