using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_1
{
    public class BankAccount
    {
        public long number { get; set; }
        public decimal deposit { get; set; }
        public long Number()
        {
            Random random = new Random();
            number = random.Next(100000000, 999999999);
            return random.Next(100000000, 999999999);
        }
        public void Deposit()
        {
            Console.WriteLine("Введите депозит вашего счета: ");
            deposit = decimal.Parse(Console.ReadLine());
        }
    }
}
