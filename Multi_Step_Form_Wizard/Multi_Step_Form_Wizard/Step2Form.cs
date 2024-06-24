using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Step_Form_Wizard
{
    public partial class Step2Form : Form
    {
        private Person _person;
        public Step2Form(Person person)
        {
            InitializeComponent();
            this._person = person;
        }

        private void button_BackStep2_Click(object sender, EventArgs e)
        {
            var step1 = new Step1Form(_person);

            step1.Show();

            this.Hide();

        }

        private void button_NextStep2_Click(object sender, EventArgs e)
        {
            int age;

            if (string.IsNullOrWhiteSpace(input_Age.Text))
            {
                output_NoAge.Text = "Enter an Age.";
                return;
            }
            
            if (int.TryParse(input_Age.Text, out age))
            {
                _person.Age = age;
            }
            else
            {
                MessageBox.Show("Invalid age.");
            }

            var step3 = new Step3Form(_person);
            step3.Show();
            this.Hide();
        }
    }
}
