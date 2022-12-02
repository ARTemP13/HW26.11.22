using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_1
{
    internal class Bank
    {
        public BankAccount CreateAccount()
        {
            BankAccount opened = new BankAccount();
            long acc = opened.Number();
            opened.Deposit();
            accounts[acc] = opened;
            return opened;
        }
        public void CloseAccount(long accountnumber)
        {
            accounts.Remove(accountnumber);
            Console.WriteLine("Аккаунт удален");
        }
        private Hashtable accounts = new Hashtable();
    }
}
