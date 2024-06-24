namespace RandomNumberGenerator
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
            button1 = new Button();
            output_GUID = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(68, 56);
            button1.Name = "button1";
            button1.Size = new Size(457, 53);
            button1.TabIndex = 0;
            button1.Text = "Create a  Globally Unique Identifier (GUID)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // output_GUID
            // 
            output_GUID.BorderStyle = BorderStyle.FixedSingle;
            output_GUID.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            output_GUID.Location = new Point(68, 122);
            output_GUID.Name = "output_GUID";
            output_GUID.Size = new Size(457, 67);
            output_GUID.TabIndex = 1;
            output_GUID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 251);
            Controls.Add(output_GUID);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Random Number Generator";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label output_GUID;
    }
}
