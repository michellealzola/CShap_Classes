using System.Text;

namespace RandomNumberGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            RandomNumberGenerator.GetRandomNumbers();

            List<string> list = RandomNumberGenerator.GetNumbers();

            StringBuilder sb = new StringBuilder();

            foreach (string number in list)
            {
                sb.Append(number);
            }

            output_GUID.Text = sb.ToString();
        }
    }
}
