namespace BankAccountManagement
{
    public partial class Form1 : Form
    {
        List<BankAccount> accounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private BankAccount AddAccount(string accountNumber, decimal balance, string ownerName)
        {
            BankAccount account = new BankAccount();

            account.AccountNumber = accountNumber;
            account.Balance = balance;
            account.OwnerName = ownerName;

            return account;
        }

        private void button_AddAccount_Click(object sender, EventArgs e)
        {
            string accountNumber = input_AccountNumber.Text;
            decimal balance = decimal.Parse(inout_Balance.Text);
            string ownerName = input_OwnerName.Text;

            accounts.Add(AddAccount(accountNumber, balance, ownerName));

            foreach (BankAccount account in accounts)
            {
                listBox1.Items.Add(account.AccountNumber.ToString());
                listBox1.Items.Add(account.Balance.ToString("C2"));
                listBox1.Items.Add(account.OwnerName.ToString());
            }


        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string search_target = input_SearchAccountNumber.Text;

            foreach (BankAccount account in accounts)
            {
                if (account.AccountNumber == search_target)
                {
                    output_Balance.Text = account.Balance.ToString("C2");
                    output_OwnerName.Text = account.OwnerName.ToString();
                }

            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
