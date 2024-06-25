namespace ReturningListofObjects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var productList = GetProductList();

            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add("ProductId", "ID");
            dataGridView1.Columns.Add("ProductName", "Name");
            dataGridView1.Columns.Add("Price", "Price");

            foreach (var product in productList)
            {
                dataGridView1.Rows.Add(product.ProductId, product.ProductName, product.Price);
            }

            dataGridView1.Columns["ProductName"].Width = 200;
        }

        private List<Product> GetProductList()
        {
            List<Product> productList = new List<Product>();
            
            Product product = new Product();
            product.SetProductId(int.Parse(input_ProductId.Text));
            product.SetProductName(input_ProductName.Text);
            product.SetPrice(decimal.Parse(input_Price.Text));

            productList.Add(product);

            return productList;
        }
    }
}
