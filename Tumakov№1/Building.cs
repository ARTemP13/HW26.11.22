using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_1
{
    internal class Building
    {
        public int number { get; set; }
        public int height { get; set; }
        public int floor { get; set; }
        public int apart { get; set; }
        public int porch { get; set; }
        public int NumberBuild()
        {
            Random random = new Random();
            number = random.Next(0,10000);
            return number;
        }

        public void InfoB()
        {
            Console.WriteLine($"Номер дома: {number}\nВысотность: {height} метров\nЭтажность: {floor}\nКоличество квартир: {apart}\nКоличество подъездов: {porch}");
            Console.WriteLine();
        }
        public void FloorHeight()
        {
            int b = height / floor;
            Console.WriteLine($"Один этаж: {b} метров");
            Console.WriteLine();
        }
        public void Apartament()
        {
            int b = apart / porch;
            Console.WriteLine($"Количесво квартир в одном подъезде: {b}");
            Console.WriteLine();
        }
        public void ApartamentFloor()
        {
            int b = (apart / porch) / floor;
            Console.WriteLine($"Количесво квартир на этаже в одном подъезде: {b}");
            Console.WriteLine();
        }
    }
}
