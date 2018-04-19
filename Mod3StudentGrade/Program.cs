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
            ArrayList stud = new ArrayList();

            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();

            student1.AddGrade(10);
            student1.AddGrade(11);
            student1.AddGrade(12);
            student1.AddGrade(13);
            student1.AddGrade(4);

            student2.AddGrade(20);
            student2.AddGrade(20);
            student2.AddGrade(30);
            student2.AddGrade(40);
            student2.AddGrade(10);

            student3.AddGrade(15);
            student3.AddGrade(16);
            student3.AddGrade(17);
            student3.AddGrade(18);
            student3.AddGrade(19);


            stud.Add(student1);
            stud.Add(student2);
            stud.Add(student3);

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
            
         
        }
        public Stack AddGrade(decimal grade)
        {
            Stack Grades = new Stack();
            Grades.Push(grade);

            return Grades;
        }
      
      
    }
}
