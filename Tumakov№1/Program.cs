using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tumakov_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            BankAccount bankAccount = new BankAccount();
            Bank Bank = new Bank();
            bankAccount = Bank.CreateAccount();
            Bank.CloseAccount(bankAccount.number);
            Console.ReadLine();

            Console.WriteLine("Задание 2");
            Creator building1 = new Creator();
            Building building2 = new Building(); 
            building2 = building1.CreateBuild();
            building1.CloseBuilding(building2.number);

            Console.ReadLine();

        }
    }
}
