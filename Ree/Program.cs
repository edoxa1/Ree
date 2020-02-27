using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ree
{

    struct Student
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public int[] Marks { get; set; }
        

        public Student(string surname, string name, string group, int[] marks)
        {
            Surname = surname;
            Name = name;
            Group = group;
            Marks = marks;
        }

        public void Info()
        {
            Console.Write($"ФИО: {Surname + " " + Name}\nГруппа: {Group}\nОценки:");
            foreach(int i in Marks)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.WriteLine("");
        }
        public void CountMarks()
        {
            int sum = 0;
            int mark = 0;
            foreach(int i in Marks)
            {
                 sum = sum + i;
            }
            mark = sum / Marks.Length;
            
            Console.WriteLine("Средняя оценка: " + mark.ToString());
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student Vasya = new Student("Vasya", "A. A", "Fiat", new int[]{ 80, 50, 78, 90, 80 });
            Vasya.Info();
            Vasya.CountMarks();
            
            Console.ReadKey();
        }
    }
}
