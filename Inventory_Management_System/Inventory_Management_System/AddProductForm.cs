namespace Inventory_Management_System
{
    public partial class AddProductForm : Form
    {

        public AddProductForm()
        {
            InitializeComponent();
        }

        private void button_AddProduct_Click(object sender, EventArgs e)
        {
            var productList = new ProductListForm();

            string productId = input_ProductId.Text;
            string name = input_Name.Text;
            decimal price;
            int quantity;

            if (decimal.TryParse(input_Price.Text, out price) && int.TryParse(input_Quantity.Text, out quantity))
            {
                Product newProduct = new Product(productId, name, price, quantity);

                ProductData.Products.Add(newProduct);

                foreach (var _product in ProductData.Products)
                {
                    productList.listBox_ProductsInfo.Items.Add($"Product ID: {_product.ProductId}");
                    productList.listBox_ProductsInfo.Items.Add($"Name: {_product.Name}");
                    productList.listBox_ProductsInfo.Items.Add($"Price: {_product.Price.ToString("C2")}");
                    productList.listBox_ProductsInfo.Items.Add($"Quantity: {_product.Quantity.ToString()}");
                }


                productList.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid input.");
            }


        }

        private void button_SearchProduct_Click(object sender, EventArgs e)
        {
            var prod_search = new SearchProductForm();
            prod_search.ShowDialog();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
