namespace SwappingObjects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private (Person, Person) SwapPerson(Person person1, Person person2)
        {
            Person Temp = person1;
            person1 = person2;
            person2 = Temp;

            return (person1, person2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person person1 = new Person(input_Name1.Text, int.Parse(input_Age1.Text));
            Person person2 = new Person(input_Name2.Text, int.Parse(input_Age2.Text));

            var person_tup = SwapPerson(person1, person2);

            listBox1.Items.Add("Person 1:");

            listBox1.Items.Add(person_tup.Item1.Name.ToString());
            listBox1.Items.Add(person_tup.Item1.Age.ToString());

            listBox1.Items.Add("==============================");

            listBox1.Items.Add("Person 2:");
            listBox1.Items.Add(person_tup.Item2.Name.ToString());
            listBox1.Items.Add(person_tup.Item2.Age.ToString());
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
