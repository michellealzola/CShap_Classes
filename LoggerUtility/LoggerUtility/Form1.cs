namespace LoggerUtility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_LogInfo_Click(object sender, EventArgs e)
        {
            Logger.LogInfo("This is just an information.");
        }

        private void button_LogWarning_Click(object sender, EventArgs e)
        {
            Logger.LogWarn("This is a warning.");
        }

        private void button_LogError_Click(object sender, EventArgs e)
        {
            Logger.LogError("This is an ERROR.");
        }

        private void button_RefreshLogs_Click(object sender, EventArgs e)
        {
            listBox_LogEntries.Items.Clear();
            List<string> logEntries = Logger.GetLogEntries();
            foreach (string logEntry in logEntries)
            {
                listBox_LogEntries.Items.Add(logEntry);
            }
            
        }
    }
}
