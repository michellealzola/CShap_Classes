namespace VehicleManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Vehicle v1 = new Vehicle("Toyota", "Rav4");

            label1.Text = v1.DisplayInfo();
        }
    }
}
