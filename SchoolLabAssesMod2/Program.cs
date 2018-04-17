using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLabAssesMod2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] students = new int[5];

            int[] a = new int[5];
            
            Student student = new Student();
            //  student.Study();
            //studArray = new Student[5];

            //Student stud1 = new Student();

            //studArray.Add(stud1);
        }
    }

    struct Student
    {
        public string Name;
        public string Age;
        public string Class;

     
        public void Study()
        {
            Console.WriteLine("Student is studying");
        }
    }
    struct Teacher
    {
        public void GradeAssignment()
        {

        }
    }
}
