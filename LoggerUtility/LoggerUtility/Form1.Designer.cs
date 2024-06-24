namespace LoggerUtility
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
            button_LogInfo = new Button();
            button_LogWarning = new Button();
            button_LogError = new Button();
            listBox_LogEntries = new ListBox();
            button_RefreshLogs = new Button();
            SuspendLayout();
            // 
            // button_LogInfo
            // 
            button_LogInfo.Location = new Point(34, 66);
            button_LogInfo.Name = "button_LogInfo";
            button_LogInfo.Size = new Size(261, 60);
            button_LogInfo.TabIndex = 0;
            button_LogInfo.Text = "Log Info";
            button_LogInfo.UseVisualStyleBackColor = true;
            button_LogInfo.Click += button_LogInfo_Click;
            // 
            // button_LogWarning
            // 
            button_LogWarning.Location = new Point(301, 66);
            button_LogWarning.Name = "button_LogWarning";
            button_LogWarning.Size = new Size(261, 60);
            button_LogWarning.TabIndex = 0;
            button_LogWarning.Text = "Log Warning";
            button_LogWarning.UseVisualStyleBackColor = true;
            button_LogWarning.Click += button_LogWarning_Click;
            // 
            // button_LogError
            // 
            button_LogError.Location = new Point(568, 66);
            button_LogError.Name = "button_LogError";
            button_LogError.Size = new Size(261, 60);
            button_LogError.TabIndex = 0;
            button_LogError.Text = "Log Error";
            button_LogError.UseVisualStyleBackColor = true;
            button_LogError.Click += button_LogError_Click;
            // 
            // listBox_LogEntries
            // 
            listBox_LogEntries.FormattingEnabled = true;
            listBox_LogEntries.ItemHeight = 25;
            listBox_LogEntries.Location = new Point(34, 225);
            listBox_LogEntries.Name = "listBox_LogEntries";
            listBox_LogEntries.Size = new Size(795, 479);
            listBox_LogEntries.TabIndex = 1;
            // 
            // button_RefreshLogs
            // 
            button_RefreshLogs.Location = new Point(34, 132);
            button_RefreshLogs.Name = "button_RefreshLogs";
            button_RefreshLogs.Size = new Size(795, 87);
            button_RefreshLogs.TabIndex = 2;
            button_RefreshLogs.Text = "Refresh Logs";
            button_RefreshLogs.UseVisualStyleBackColor = true;
            button_RefreshLogs.Click += button_RefreshLogs_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 750);
            Controls.Add(button_RefreshLogs);
            Controls.Add(listBox_LogEntries);
            Controls.Add(button_LogError);
            Controls.Add(button_LogWarning);
            Controls.Add(button_LogInfo);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Logger Utility";
            ResumeLayout(false);
        }

        #endregion

        private Button button_LogInfo;
        private Button button_LogWarning;
        private Button button_LogError;
        private ListBox listBox_LogEntries;
        private Button button_RefreshLogs;
    }
}
