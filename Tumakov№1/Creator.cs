using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_1
{
    internal class Creator
    {
        public Building CreateBuild()
        {
            Building building = new Building();
            int num = building.NumberBuild();
            Console.WriteLine("Введите высоту здания");
            building.height = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество подъездов");
            building.porch = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество квартир");
            building.apart = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите этажность здания");
            building.floor = int.Parse(Console.ReadLine());
            build[num] = building;
            return building;
        }
        
        public void CloseBuilding(int NumberBuilding)
        {
            build.Remove(NumberBuilding);
            Console.WriteLine("Дом снесен");
        }
        private static Hashtable build = new Hashtable();
    }
}
