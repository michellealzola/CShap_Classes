namespace CreateMutableClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_DisplayCurrentState_Click(object sender, EventArgs e)
        {
            var person = new Person();

            string name = input_name.Text;
            int age;

            if (name != null && int.TryParse(input_Age.Text, out age))
            {
                person.Name = name;
                person.Age = age;

                output_CurrentState.Text = person.ToString();
            }
        }
    }
}
