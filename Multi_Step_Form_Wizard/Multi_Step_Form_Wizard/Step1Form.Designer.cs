namespace Multi_Step_Form_Wizard
{
    partial class Step1Form
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
            input_Name = new TextBox();
            output_NoName = new Label();
            button_NextStep1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 48);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // input_Name
            // 
            input_Name.Location = new Point(139, 44);
            input_Name.Name = "input_Name";
            input_Name.Size = new Size(270, 33);
            input_Name.TabIndex = 1;
            // 
            // output_NoName
            // 
            output_NoName.Location = new Point(35, 120);
            output_NoName.Name = "output_NoName";
            output_NoName.Size = new Size(374, 32);
            output_NoName.TabIndex = 2;
            // 
            // button_NextStep1
            // 
            button_NextStep1.Location = new Point(36, 174);
            button_NextStep1.Name = "button_NextStep1";
            button_NextStep1.Size = new Size(91, 51);
            button_NextStep1.TabIndex = 3;
            button_NextStep1.Text = "Next";
            button_NextStep1.UseVisualStyleBackColor = true;
            button_NextStep1.Click += button_NextStep1_Click;
            // 
            // Step1Form
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 311);
            Controls.Add(button_NextStep1);
            Controls.Add(output_NoName);
            Controls.Add(input_Name);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Step1Form";
            Text = "Step 1";
            Load += Step1Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox input_Name;
        private Label output_NoName;
        private Button button_NextStep1;
    }
}
