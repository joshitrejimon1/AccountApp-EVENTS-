using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp_EVENTS_.Model
{
    delegate void DBalanceCHange(Account account);
    internal class Account// PUBLISHER 
    {
        public int AccountNo { get; set; }
        public string AccountName { get; set; }
        public double Balance { get; set; }

        public event DBalanceCHange OnBalanceChanged;// default null 


        public void Desposite(double amount)
        {
            Balance += amount;
            if (OnBalanceChanged != null)// check for aubscribers 
                OnBalanceChanged(this);

        }

        public Account(int accountNo, string name, double balance)
        {
            AccountNo = accountNo;
            AccountName = name;
            Balance = balance;
        }

    }
}
