namespace DistanceCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Distance(int x, int y)
        {
            Point points = new Point(x, y);

            return points.CalculateDistance();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            int distance;

            if (int.TryParse(input_x.Text, out x) && int.TryParse(input_y.Text, out y))
            {
                distance = Distance(x, y);
                output_distance.Text = distance.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input.");
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
