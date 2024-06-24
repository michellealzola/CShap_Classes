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
    public partial class Step3Form : Form
    {
        private Person _person;
        public Step3Form(Person person)
        {
            InitializeComponent();
            _person = person;
        }

        private void button_BackStep3_Click(object sender, EventArgs e)
        {
            var step2 = new Step2Form(_person);
            step2.Show();
            this.Hide();
        }

        private void button_NextStep3_Click(object sender, EventArgs e)
        {
            string birth = input_Birth.Text;

            if (string.IsNullOrWhiteSpace(birth))
            {
                output_NoBirth.Text = "Please enter birth.";
                return;
            }

            _person.Birth = birth;

            var summary = new SummaryForm(_person);
            summary.Show();
            this.Hide();
        }
    }
}
