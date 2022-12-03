using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_2
{
    public enum Type
    {
        Actual,
        Save
    }
    public class BankAccount
    {
        
        public int AccountNumber { get; set; }
        public double Balance { get; set; }
        public Type AccountType { get; set; }
        
        

        public BankAccount(int AccountNumber, double Balance, Type AccountType)
        {
            this.AccountNumber = AccountNumber;
            this.Balance = Balance;
            this.AccountType = AccountType;
        }
        public override bool Equals(object obj)
        {
            if (obj is BankAccount)
            {
                BankAccount bank1 = obj as BankAccount;
                bool a =  bank1.Balance == Balance && bank1.AccountType == AccountType;
                return a;
            }
            else
            {
                return false;
            }
        }



        public static bool operator == (BankAccount bank1, BankAccount bank2)
        {
            if ((bank1.Balance == bank2.Balance) && (bank1.AccountType == bank2.AccountType))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator != (BankAccount bank1, BankAccount bank2)
        {
            if ((bank1.Balance != bank2.Balance) && (bank1.AccountType != bank2.AccountType))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return AccountNumber;
        }

        public override string ToString()
        {
            Console.WriteLine("Информация о аккаунте получена");
            return $"Номер аккаунта: {AccountNumber}\nБаланс: {Balance}\nТип аккаунта: {AccountType}";
        }
    }
    
}
