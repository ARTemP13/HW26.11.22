using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HW26._11._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            string path = "Student.txt";
            String[] readText = File.ReadAllLines(path);
            List<Student> students = new List<Student>();
            for (int i = 0; i < readText.Length; i++)
            {
                string[] words = readText[i].Split(' ');
                Student student = new Student(words[0], int.Parse(words[1]));
                students.Add(student);
            }
            int l = 0;
            int MeasureAmount = 0;
            int[] PeopleAmount = new int[students.Count];
            while (l == 0)
            {
                Console.Write("Введите название мероприятия: ");
                string measure = Console.ReadLine();
                Console.Write("Введите количество участников: ");
                int people = int.Parse(Console.ReadLine());
                File.AppendAllText("Measure.txt", measure + "\n");
                Random random = new Random();
                int[] MeasurePeople = new int[people];
                int s = 0;
                if (MeasureAmount == 3)
                {
                    for (int i = 0; i < students.Count; i++)
                    {
                        if (PeopleAmount[i] == 0)
                        {
                            MeasurePeople[s] = i;
                            s++;
                        }
                    }
                    for (int i = 0; i < students.Count; i++)
                    {
                        PeopleAmount[i] = 0;
                    }
                }
                for (int i = s; i < people; i++)
                {
                    int h = random.Next(0, students.Count);
                    for (int j = 0; j < MeasurePeople.Length; j++)
                    {
                        if (h == MeasurePeople[j])
                        {
                            h = random.Next(0, students.Count);
                            j = -1;
                        }
                    }
                    MeasurePeople[i] = h;
                }
                int y = 0;
                for (int i = 1; i < MeasurePeople.Length; i++)
                {
                    if (students[MeasurePeople[0]].Group != students[MeasurePeople[i]].Group)
                    {
                        y++;
                        break;
                    }
                }
                if (y == 0)
                {
                    Console.WriteLine("В соревнованиях участвует только одна группа, соревнование не могут проводиться");
                    continue;
                }
                else
                {
                    Console.WriteLine("Введите дату розыгрыша: ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Что разыгрывается: ");
                    string gift = Console.ReadLine();

                    string time = date.ToString("dd.MM.yyyy");
                    File.AppendAllText("Measure.txt", "Дата розыгрыша: " + time + " Подарок: " + gift + "\nУчастники: ");
                    for (int i = 0; i < MeasurePeople.Length; i++)
                    {
                        File.AppendAllText("Measure.txt", students[MeasurePeople[i]].Name + " " + (students[MeasurePeople[i]].Group).ToString() + " группа \n");
                    }
                    MeasureAmount++;
                }
                Console.WriteLine("Мероприятие закончено\nорганизовать мероприятие - 0\nвыйти - 1 ");
                int k = int.Parse(Console.ReadLine());
                if (k == 1)
                {
                    l++;
                }

            }
            Console.ReadKey();




            Console.WriteLine("Задание 2");
            
            People people1 = new People("Алексей", "Уху, это подходит");
            people1.hobby[0] = "митинг";
            people1.hobby[1] = "мультик";
            people1.hobby[2] = "спорт";
            People people2 = new People("Григорий", "Ммм....");
            people2.hobby[0] = "науке";
            people2.hobby[1] = "сериал";
            people2.hobby[2] = "книга";
            People people3 = new People("Владимир", "А это правильно!");
            people3.hobby[0] = "игра";
            people3.hobby[1] = "фильм";
            people3.hobby[2] = "отдыха";

            // вышел новый сериал
            // вышел новый мультик
            // вышла новая игра
            // прошел митинг
            // прошел спорт марафон
            // новое достижение в науке
            // вышла новая книга
            // пришло время отдыха
            // вышел новый фильм

            int l2 = 0;
            while(l2 == 0)
            {
                Console.WriteLine("Введите произошедшое событие");
                string Events = Console.ReadLine();
                string[] strings = Events.Split(' ');
                for(int i = 0; i < strings.Length; i++)
                {
                    for(int j = 0; j < strings.Length; j++)
                    {
                        if (people1.hobby[i] == strings[j])
                        {
                            Notify.Invoke(people1.phrase);
                        }
                    }
                    
                }
                for (int i = 0; i < strings.Length; i++)
                {
                    for (int j = 0; j < strings.Length; j++)
                    {
                        if (people2.hobby[i] == strings[j])
                        {
                            Notify.Invoke(people2.phrase);
                        }
                    }

                }
                for (int i = 0; i < strings.Length; i++)
                {
                    for (int j = 0; j < strings.Length; j++)
                    {
                        if (people3.hobby[i] == strings[j])
                        {
                            Notify.Invoke(people3.phrase);
                        }
                    }

                }

            }
            Console.ReadKey();

        }
        public delegate void PeopleHobby(string message);
        public static event PeopleHobby Notify;
    }
}
