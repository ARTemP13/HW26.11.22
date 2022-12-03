using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            BankAccount bankaccount1 = new BankAccount(4567890, 10000, Type.Actual);
            BankAccount bankaccount2 = new BankAccount(4567891, 480, Type.Save);
            BankAccount bankaccount3 = new BankAccount(4567892, 5780, Type.Actual);
            bankaccount1.Equals(bankaccount2);
            bankaccount1.GetHashCode();
            bankaccount2.ToString();
            Console.ReadKey();

            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите числитель первой дроби:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите знаменатель первой дроби:");
            int denom1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите числитель второй дроби:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите знаменатель второй дроби:");
            int denom2 = int.Parse(Console.ReadLine());
            RationalNumber r1 = new RationalNumber(num1, denom1);
            RationalNumber r2 = new RationalNumber(num2, denom2);
            double r3 = r1 + r2;
            bool r4 = r1 < r2;
            bool r5 = r1 >= r2;
            double r6 = r1 - r2;
            Console.ReadKey();

            Console.WriteLine("Задание 3");
            Console.Write("Введите вещественную часть первого комплексного числа: ");
            int real1 = int.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть первого комплексного числа: ");
            int im1 = int.Parse(Console.ReadLine());
            Console.Write("Введите вещественную часть второго комплексного числа: ");
            int real2 = int.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть первого комплексного числа: ");
            int im2 = int.Parse(Console.ReadLine());
            ComplexNumber c1 = new ComplexNumber(real1, im1);
            ComplexNumber c2 = new ComplexNumber(real1, im2);
            Console.WriteLine("Введенные комплексные числа: ");
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());
            Console.WriteLine("Сложение комплексных чисел:");
            Console.WriteLine(c1 + c2);
            Console.WriteLine("Умножение комплексных чисел:");
            Console.WriteLine(c1 * c2);
            Console.ReadKey();

            Console.WriteLine("Задание 4");
            Book book = new Book("Generation P", "Пелевин", "Манн Иванов и Фербер");
            Book book1 = new Book("Идиот", "Достоевский", "Просвещение");
            Book book2 = new Book("1984", "Джордж Оруэлл", "АСТ");
            List<Book> books = new List<Book>();
            books.Add(book1);
            books.Add(book2);
            books.Add(book);

            Sort sort;
            sort = BookContainer.SortName;
            sort(books);

            sort = BookContainer.SortAuthor;
            sort(books);
            
            sort = BookContainer.SortPublish;
            sort(books);

            Console.ReadKey();
        }
        delegate List<Book> Sort(List<Book> books);
    }
}
