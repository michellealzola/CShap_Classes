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
    public partial class SummaryForm : Form
    {
        private Person _person;
        public SummaryForm(Person person)
        {
            InitializeComponent();
            _person = person;
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            listBox_Summary.Items.Clear();
            
            listBox_Summary.Items.Add(_person.Name);
            listBox_Summary.Items.Add(_person.Age.ToString());
            listBox_Summary.Items.Add(_person.Birth);
        }
    }
}
