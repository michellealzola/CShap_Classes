namespace ReturningCustomObjectfromMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_CreatePerson_Click(object sender, EventArgs e)
        {
            var _person = CreatePerson();

            listBox_Person.Items.Clear();
            listBox_Person.Items.Add($"Name: {_person.Name}");
            listBox_Person.Items.Add($"Age: {_person.Age.ToString()}");
            listBox_Person.Items.Add($"Email: {_person.Email}");

        }

        private Person CreatePerson()
        {
            Person person = new Person();
            person.SetName(input_Name.Text);
            person.SetEmail(input_Email.Text);
            person.SetAge(int.Parse(input_Age.Text));

            return person;

        }
    }
}
