namespace CreateImmutableClass
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
            input_Make = new TextBox();
            input_Model = new TextBox();
            input_Year = new TextBox();
            button_DisplayCurrentState = new Button();
            output_CurrentState = new Label();
            Modify = new GroupBox();
            button_ModifyCurrentState = new Button();
            modify_Year = new TextBox();
            modify_Model = new TextBox();
            modify_Make = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Modify.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 92);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 0;
            label1.Text = "Make";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 154);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 1;
            label2.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 216);
            label3.Name = "label3";
            label3.Size = new Size(48, 25);
            label3.TabIndex = 2;
            label3.Text = "Year";
            // 
            // input_Make
            // 
            input_Make.Location = new Point(207, 88);
            input_Make.Name = "input_Make";
            input_Make.Size = new Size(350, 33);
            input_Make.TabIndex = 1;
            // 
            // input_Model
            // 
            input_Model.Location = new Point(207, 150);
            input_Model.Name = "input_Model";
            input_Model.Size = new Size(350, 33);
            input_Model.TabIndex = 2;
            // 
            // input_Year
            // 
            input_Year.Location = new Point(207, 212);
            input_Year.Name = "input_Year";
            input_Year.Size = new Size(350, 33);
            input_Year.TabIndex = 3;
            // 
            // button_DisplayCurrentState
            // 
            button_DisplayCurrentState.Location = new Point(72, 298);
            button_DisplayCurrentState.Name = "button_DisplayCurrentState";
            button_DisplayCurrentState.Size = new Size(485, 60);
            button_DisplayCurrentState.TabIndex = 6;
            button_DisplayCurrentState.Text = "Display Current State";
            button_DisplayCurrentState.UseVisualStyleBackColor = true;
            button_DisplayCurrentState.Click += button_DisplayCurrentState_Click;
            // 
            // output_CurrentState
            // 
            output_CurrentState.BackColor = Color.FromArgb(255, 192, 192);
            output_CurrentState.BorderStyle = BorderStyle.FixedSingle;
            output_CurrentState.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            output_CurrentState.ForeColor = SystemColors.ButtonHighlight;
            output_CurrentState.Location = new Point(72, 386);
            output_CurrentState.Name = "output_CurrentState";
            output_CurrentState.Size = new Size(485, 230);
            output_CurrentState.TabIndex = 7;
            output_CurrentState.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Modify
            // 
            Modify.Controls.Add(button_ModifyCurrentState);
            Modify.Controls.Add(modify_Year);
            Modify.Controls.Add(modify_Model);
            Modify.Controls.Add(modify_Make);
            Modify.Controls.Add(label4);
            Modify.Controls.Add(label5);
            Modify.Controls.Add(label6);
            Modify.Location = new Point(612, 59);
            Modify.Name = "Modify";
            Modify.Size = new Size(428, 557);
            Modify.TabIndex = 8;
            Modify.TabStop = false;
            Modify.Text = "groupBox1";
            // 
            // button_ModifyCurrentState
            // 
            button_ModifyCurrentState.Location = new Point(18, 243);
            button_ModifyCurrentState.Name = "button_ModifyCurrentState";
            button_ModifyCurrentState.Size = new Size(385, 60);
            button_ModifyCurrentState.TabIndex = 13;
            button_ModifyCurrentState.Text = "Modify Current State";
            button_ModifyCurrentState.UseVisualStyleBackColor = true;
            button_ModifyCurrentState.Click += button_ModifyCurrentState_Click;
            // 
            // modify_Year
            // 
            modify_Year.Location = new Point(153, 157);
            modify_Year.Name = "modify_Year";
            modify_Year.Size = new Size(250, 33);
            modify_Year.TabIndex = 12;
            // 
            // modify_Model
            // 
            modify_Model.Location = new Point(153, 95);
            modify_Model.Name = "modify_Model";
            modify_Model.Size = new Size(250, 33);
            modify_Model.TabIndex = 10;
            // 
            // modify_Make
            // 
            modify_Make.Location = new Point(153, 33);
            modify_Make.Name = "modify_Make";
            modify_Make.Size = new Size(250, 33);
            modify_Make.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 161);
            label4.Name = "label4";
            label4.Size = new Size(48, 25);
            label4.TabIndex = 11;
            label4.Text = "Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 99);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 9;
            label5.Text = "Model";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 37);
            label6.Name = "label6";
            label6.Size = new Size(58, 25);
            label6.TabIndex = 7;
            label6.Text = "Make";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 646);
            Controls.Add(Modify);
            Controls.Add(output_CurrentState);
            Controls.Add(button_DisplayCurrentState);
            Controls.Add(input_Year);
            Controls.Add(input_Model);
            Controls.Add(input_Make);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Immutable Class";
            Modify.ResumeLayout(false);
            Modify.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox input_Make;
        private TextBox input_Model;
        private TextBox input_Year;
        private Button button_DisplayCurrentState;
        private Label output_CurrentState;
        private GroupBox Modify;
        private Button button_ModifyCurrentState;
        private TextBox modify_Year;
        private TextBox modify_Model;
        private TextBox modify_Make;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
