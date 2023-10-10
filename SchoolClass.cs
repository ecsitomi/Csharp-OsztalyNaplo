using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsztalyNaplo
{
    internal class SchoolClass
    {
        private List<Student> students;

        public SchoolClass()
        { 
            students = new List<Student>();
        }
        public void AddStudent(Student student) 
        { 
            students.Add(student); 
        }

        public void PrintClassInfo() {
            Console.WriteLine("Az osztály diákjai: ");
            foreach (var student in students) 
            {
                student.PrintStudentInfo();
                Console.WriteLine();
            }
        }


    }

}
