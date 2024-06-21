using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagement
{
    internal class BankAccount
    {
        private string _accountNumber;
        private decimal _balance;
        private string _ownerName;


        public BankAccount()
        {
            _accountNumber = string.Empty;
            _balance = 0;
            _ownerName = string.Empty;
        }

        public string AccountNumber { get { return _accountNumber; } set { _accountNumber = value; } }
        public decimal Balance { get { return _balance; } set { _balance = value; } }
        public string OwnerName { get { return _ownerName; } set { _ownerName = value; } }
    }
}
