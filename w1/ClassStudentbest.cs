using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudent
{
     
    class Student
    {
        public string name;
        public string surname;
        public int curs;
        public float gpa;
        public string stependia;

        public Student()
        {
            name = "James";
            surname = "Rodrigues";
            curs = 4;
            gpa=2.96f;
            stependia = "Yes";
        }

        public Student(string name, string surname, int curs, float gpa, string stependia)
        {
            this.name = name;
            this.surname = surname;
            this.curs = curs;
            this.gpa = gpa;
            this.stependia = stependia;
        }
 
        public override string ToString()
        {
            return "Student : " + "\nName : " + name + "\nSurname : " + surname + "\nCurs : " + curs + "\nGpa : " + gpa + "\nStependia : " + stependia;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("John", "Taylor", 3, 2.33f, "No");
            Console.WriteLine(student1);
            Console.WriteLine();

            Student student2 = new Student();
            student2.gpa = 4f;
            Console.WriteLine(student2);
            Console.WriteLine();

            Student student3 = new Student();
            student3.name = "Yeldar";
            student3.surname = "Mukhametkazin";
            student3.curs = 1;
            student3.gpa = 2.96f;
            student3.stependia = "Yes";
            Console.WriteLine(student3);
            Console.ReadKey();
        }
    }
}
