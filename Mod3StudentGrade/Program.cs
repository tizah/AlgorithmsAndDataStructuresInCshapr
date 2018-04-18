using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3StudentGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList stud = new ArrayList(4);

            Student obj = new Student();
            stud.Add(obj);

            foreach (var students in stud)
            {
                Console.WriteLine(students);
            }

        }
    }

    class Student
    {
        public string Name;
        public string Class;
        public Student()
        {
            List<Student> student = new List<Student>()
            {
                new Student() {Class = "jss 2", Name="David"},
                 new Student() {Class = "jss 3", Name="Tirzah"},
                  new Student() {Class = "jss 4", Name="Zagi"},
            };
            

         
        }
        public Stack AddGrade(decimal grade)
        {
            Stack Grades = new Stack();
            Grades.Push(5);
            Grades.Push(10);
            Grades.Push(15);
            Grades.Push(20);
            Grades.Push(25);
            return Grades;
        }
      
      
    }
}
