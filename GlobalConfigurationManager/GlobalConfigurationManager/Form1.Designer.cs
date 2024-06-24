namespace GlobalConfigurationManager
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
            comboBox_Theme = new ComboBox();
            label1 = new Label();
            comboBox_Language = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            button_SaveConfig = new Button();
            numericUpDown_FontSize = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_FontSize).BeginInit();
            SuspendLayout();
            // 
            // comboBox_Theme
            // 
            comboBox_Theme.FormattingEnabled = true;
            comboBox_Theme.Items.AddRange(new object[] { "Light", "Dark", "Sea" });
            comboBox_Theme.Location = new Point(26, 71);
            comboBox_Theme.Name = "comboBox_Theme";
            comboBox_Theme.Size = new Size(247, 33);
            comboBox_Theme.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 34);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 1;
            label1.Text = "Select Theme:";
            // 
            // comboBox_Language
            // 
            comboBox_Language.FormattingEnabled = true;
            comboBox_Language.Items.AddRange(new object[] { "English", "Spanish", "French" });
            comboBox_Language.Location = new Point(279, 71);
            comboBox_Language.Name = "comboBox_Language";
            comboBox_Language.Size = new Size(247, 33);
            comboBox_Language.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(279, 34);
            label2.Name = "label2";
            label2.Size = new Size(154, 25);
            label2.TabIndex = 1;
            label2.Text = "Select Language:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(531, 34);
            label3.Name = "label3";
            label3.Size = new Size(147, 25);
            label3.TabIndex = 1;
            label3.Text = "Select Font Size:";
            // 
            // button_SaveConfig
            // 
            button_SaveConfig.Location = new Point(26, 129);
            button_SaveConfig.Name = "button_SaveConfig";
            button_SaveConfig.Size = new Size(247, 53);
            button_SaveConfig.TabIndex = 2;
            button_SaveConfig.Text = "Save Configuration";
            button_SaveConfig.UseVisualStyleBackColor = true;
            button_SaveConfig.Click += button_SaveConfig_Click;
            // 
            // numericUpDown_FontSize
            // 
            numericUpDown_FontSize.Location = new Point(544, 72);
            numericUpDown_FontSize.Name = "numericUpDown_FontSize";
            numericUpDown_FontSize.Size = new Size(120, 33);
            numericUpDown_FontSize.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 214);
            Controls.Add(numericUpDown_FontSize);
            Controls.Add(button_SaveConfig);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox_Language);
            Controls.Add(comboBox_Theme);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Global Configuration Manager";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown_FontSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_Theme;
        private Label label1;
        private ComboBox comboBox_Language;
        private Label label2;
        private Label label3;
        private Button button_SaveConfig;
        private NumericUpDown numericUpDown_FontSize;
    }
}
