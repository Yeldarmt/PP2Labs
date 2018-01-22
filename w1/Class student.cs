using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student2
{

    class Program
    {
        class student
        {
            string name, surname;
            int age;
            float gpa;
            public student(string name,string surname, int age, float gpa)
            {
                this.name = name;
                this.surname = surname;
                this.age = age;
                this.gpa = gpa;
            }
            public override string ToString()
            {
                return "Your name is: " + name + "\n Your surname is: " + surname + "\n Your age: " + age + "\n Your gpa: " + gpa;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Surname:");
            string surname = Console.ReadLine();
            Console.WriteLine("Age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Gpa:");
            float gpa = float.Parse(Console.ReadLine());
            student a = new student(name, surname, age, gpa);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
