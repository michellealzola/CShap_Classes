namespace CreateImmutableClass
{
    public partial class Form1 : Form
    {
        private Car car;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_DisplayCurrentState_Click(object sender, EventArgs e)
        {
            string make = input_Make.Text;
            string model = input_Model.Text;
            int year = int.Parse(input_Year.Text);

            car = new Car
            {
                Make = make,
                Model = model,
                Year = year
            };

            output_CurrentState.Text = car.DisplayCar();

        }

        private void button_ModifyCurrentState_Click(object sender, EventArgs e)
        {
            string make = modify_Make.Text;
            string model = modify_Model.Text;
            int year = int.Parse (modify_Year.Text);

            output_CurrentState.Text = "Cannot change properties of current state.";
        
        }
    }
}
