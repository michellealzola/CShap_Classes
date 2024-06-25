namespace EmployeeClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_DisplayInfo_Click(object sender, EventArgs e)
        {
            var employee = new Employee();

            string firstName = input_FirstName.Text;
            string lastName = input_LastName.Text;
            string position = input_Position.Text;

            employee.SetFirstName(firstName);
            employee.SetLastName(lastName);
            employee.SetPosition(position);

            output_EmployeeInfo.Text = employee.ToString();            

        }
    }
}
