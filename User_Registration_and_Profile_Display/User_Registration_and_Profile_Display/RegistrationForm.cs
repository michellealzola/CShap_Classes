namespace User_Registration_and_Profile_Display
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void button_DisplayUserInfo_Click(object sender, EventArgs e)
        {
            var profile = new ProfileForm();

            profile.output_Name.Text = input_Name.Text;
            profile.output_Email.Text = input_Email.Text;
            profile.output_Password.Text = input_Password.Text;

            profile.ShowDialog();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
