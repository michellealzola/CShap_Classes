namespace DeepCopyingMutableClasses
{
    public partial class Form1 : Form
    {
        private Person origPerson;
        private Person copiedPerson;


        public Form1()
        {
            InitializeComponent();
        }

        private void button_CreatePerson_Click(object sender, EventArgs e)
        {
            output_OrigPerson.Text = "";
            output_CopiedPerson.Text = "";

            string name = input_Name.Text;
            string houseNum = input_HouseNumber.Text;
            string streetName = input_StreetName.Text;
            string city = input_City.Text;

            Address address = new Address(houseNum, streetName, city);
            origPerson = new Person(name, address);

            copiedPerson = new Person(origPerson);

            DisplayPerson();


        }

        public void DisplayPerson()
        {
            output_OrigPerson.Text = $"{origPerson.Name} | {origPerson.Address.HouseNumber} |" +
                $"{origPerson.Address.StreetName} | {origPerson.Address.City}";

            output_CopiedPerson.Text = $"{copiedPerson.Name} | {copiedPerson.Address.HouseNumber} |" +
                $"{copiedPerson.Address.StreetName} | {copiedPerson.Address.City}";
        }

        private void button_ModifyAddress_Click(object sender, EventArgs e)
        {

            string houseNum = input_HouseNumber.Text;
            string streetName = input_StreetName.Text;
            string city = input_City.Text;

            origPerson.Address.HouseNumber = houseNum;
            origPerson.Address.StreetName = streetName;
            origPerson.Address.City = city;

            DisplayPerson();
        }
    }
}
