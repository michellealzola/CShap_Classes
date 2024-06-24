namespace Multi_Step_Form_Wizard
{
    partial class Step3Form
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
            button_NextStep3 = new Button();
            button_BackStep3 = new Button();
            output_NoBirth = new Label();
            input_Birth = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button_NextStep3
            // 
            button_NextStep3.Location = new Point(128, 195);
            button_NextStep3.Name = "button_NextStep3";
            button_NextStep3.Size = new Size(91, 51);
            button_NextStep3.TabIndex = 11;
            button_NextStep3.Text = "Next";
            button_NextStep3.UseVisualStyleBackColor = true;
            button_NextStep3.Click += button_NextStep3_Click;
            // 
            // button_BackStep3
            // 
            button_BackStep3.Location = new Point(31, 195);
            button_BackStep3.Name = "button_BackStep3";
            button_BackStep3.Size = new Size(91, 51);
            button_BackStep3.TabIndex = 12;
            button_BackStep3.Text = "Back";
            button_BackStep3.UseVisualStyleBackColor = true;
            button_BackStep3.Click += button_BackStep3_Click;
            // 
            // output_NoBirth
            // 
            output_NoBirth.Location = new Point(30, 141);
            output_NoBirth.Name = "output_NoBirth";
            output_NoBirth.Size = new Size(374, 32);
            output_NoBirth.TabIndex = 10;
            // 
            // input_Birth
            // 
            input_Birth.Location = new Point(134, 65);
            input_Birth.Name = "input_Birth";
            input_Birth.Size = new Size(270, 33);
            input_Birth.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 69);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 8;
            label1.Text = "Birth:";
            // 
            // Step3Form
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 311);
            Controls.Add(button_NextStep3);
            Controls.Add(button_BackStep3);
            Controls.Add(output_NoBirth);
            Controls.Add(input_Birth);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Step3Form";
            Text = "Step 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_NextStep3;
        private Button button_BackStep3;
        private Label output_NoBirth;
        private TextBox input_Birth;
        private Label label1;
    }
}