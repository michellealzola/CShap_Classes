namespace CreateMutableClass
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
            input_name = new TextBox();
            input_Age = new TextBox();
            button_DisplayCurrentState = new Button();
            output_CurrentState = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 73);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 139);
            label2.Name = "label2";
            label2.Size = new Size(45, 25);
            label2.TabIndex = 1;
            label2.Text = "Age";
            // 
            // input_name
            // 
            input_name.Location = new Point(183, 69);
            input_name.Name = "input_name";
            input_name.Size = new Size(350, 33);
            input_name.TabIndex = 1;
            // 
            // input_Age
            // 
            input_Age.Location = new Point(183, 135);
            input_Age.Name = "input_Age";
            input_Age.Size = new Size(350, 33);
            input_Age.TabIndex = 2;
            // 
            // button_DisplayCurrentState
            // 
            button_DisplayCurrentState.BackColor = SystemColors.ActiveCaption;
            button_DisplayCurrentState.FlatStyle = FlatStyle.Flat;
            button_DisplayCurrentState.ForeColor = SystemColors.ButtonHighlight;
            button_DisplayCurrentState.Location = new Point(76, 214);
            button_DisplayCurrentState.Name = "button_DisplayCurrentState";
            button_DisplayCurrentState.Size = new Size(457, 54);
            button_DisplayCurrentState.TabIndex = 3;
            button_DisplayCurrentState.Text = "Display Current State";
            button_DisplayCurrentState.UseVisualStyleBackColor = false;
            button_DisplayCurrentState.Click += button_DisplayCurrentState_Click;
            // 
            // output_CurrentState
            // 
            output_CurrentState.BorderStyle = BorderStyle.FixedSingle;
            output_CurrentState.FlatStyle = FlatStyle.Flat;
            output_CurrentState.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            output_CurrentState.Location = new Point(76, 298);
            output_CurrentState.Name = "output_CurrentState";
            output_CurrentState.Size = new Size(457, 63);
            output_CurrentState.TabIndex = 4;
            output_CurrentState.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 446);
            Controls.Add(output_CurrentState);
            Controls.Add(button_DisplayCurrentState);
            Controls.Add(input_Age);
            Controls.Add(input_name);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form1";
            Text = "Mutable Class";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox input_name;
        private TextBox input_Age;
        private Button button_DisplayCurrentState;
        private Label output_CurrentState;
    }
}
