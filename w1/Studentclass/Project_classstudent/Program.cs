using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_classstudent
{
    class Student
    {
        string name;
        int age;
        float gpa;
        public Student()
        {
            name = "Aaa";
            age = 18;
            gpa = 4;
        }
        public Student(string n , int a , float g)
        {
            name = n;
            age = a;
            gpa = g;
        }
        public override string ToString()
        {
            return name + " " + age + " " + gpa;
        }
        static void Main(string[] args)
        {
            Student s = new Student();
            s.name = "FIT";
            s.age = 20;
            Console.WriteLine(s);

            Student s2 = new Student("asdf", 19, 3);
            Console.WriteLine(s2);
            Console.ReadKey();
        }

    }
}
