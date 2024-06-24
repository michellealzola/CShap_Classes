namespace GlobalConfigurationManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_Theme.SelectedItem = ConfigManager.Theme;
            comboBox_Language.SelectedItem = ConfigManager.Language;
            numericUpDown_FontSize.Value = ConfigManager.FontSize;
        }

        private void button_SaveConfig_Click(object sender, EventArgs e)
        {
            ConfigManager.SetTheme(comboBox_Theme.SelectedItem.ToString());
            ConfigManager.SetLanguage(comboBox_Language.SelectedItem.ToString());
            ConfigManager.SetFontSize((int)numericUpDown_FontSize.Value);

            MessageBox.Show("Configuration Settings are saved successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
