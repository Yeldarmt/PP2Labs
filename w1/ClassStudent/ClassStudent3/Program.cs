using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudent3
{
    public class Student
    {
        public string firstname;
        public string lastname;
        public int age;
        public string group;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student();
            student1.group = "Group1";
            student2.group = "Group2";
            student1.firstname = "Nicolay";
            student2.firstname = "Jhon";
            Console.WriteLine("The first student's name is " + student1.firstname);
            Console.WriteLine("The second student's name is " + student2.firstname);
            Console.WriteLine(student2.group);
            Console.WriteLine(student1.group);
            Console.ReadKey();
        }
    }
}
