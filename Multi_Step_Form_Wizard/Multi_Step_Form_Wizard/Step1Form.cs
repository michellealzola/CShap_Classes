namespace Multi_Step_Form_Wizard
{
    public partial class Step1Form : Form
    {
        private Person _person;

        public Step1Form(Person person)
        {
            InitializeComponent();
            this._person = person;
        }

        private void Step1Form_Load(object sender, EventArgs e)
        {

        }

        private void button_NextStep1_Click(object sender, EventArgs e)
        {
            string name = input_Name.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                output_NoName.Text = "Please enter a name.";
                return;
                
            }
            
            _person.Name = name;

            var step2 = new Step2Form(_person);
            step2.Show();
            this.Hide();

            
            
        }
    }
}
