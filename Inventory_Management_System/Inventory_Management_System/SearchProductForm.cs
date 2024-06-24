using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class SearchProductForm : Form
    {
        public SearchProductForm()
        {
            InitializeComponent();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            listBox_SearchResult.Items.Clear();
            string target = input_Search.Text;
            bool productFound = false;


            foreach (var _product in ProductData.Products)
            {
                if (_product.ProductId == target)
                {
                    listBox_SearchResult.Items.Add(_product.ProductId);
                    listBox_SearchResult.Items.Add(_product.Name);
                    listBox_SearchResult.Items.Add(_product.Price);
                    listBox_SearchResult.Items.Add(_product.Quantity);

                    productFound = true;

                    break;
                }
                
            }

            if (!productFound)
            {
                listBox_SearchResult.Items.Add("Product not found:");
            }



        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
