namespace Multi_Step_Form_Wizard
{
    partial class SummaryForm
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
            listBox_Summary = new ListBox();
            SuspendLayout();
            // 
            // listBox_Summary
            // 
            listBox_Summary.FormattingEnabled = true;
            listBox_Summary.ItemHeight = 25;
            listBox_Summary.Location = new Point(24, 29);
            listBox_Summary.Name = "listBox_Summary";
            listBox_Summary.Size = new Size(378, 254);
            listBox_Summary.TabIndex = 0;
            // 
            // SummaryForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 311);
            Controls.Add(listBox_Summary);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "SummaryForm";
            Text = "Summary";
            Load += SummaryForm_Load;
            ResumeLayout(false);
        }

        #endregion

        protected internal ListBox listBox_Summary;
    }
}