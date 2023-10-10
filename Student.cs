using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsztalyNaplo
{
    internal class Student
    {
        public string Name { get; set; }
        public List<int> Grades { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string ParentName { get; set; }
        public string Email { get; set; }

        public Student(string name, List<int> grades, string address, int age, string parentName, string email)
        {
            Name = name;
            Grades = new List<int>();
            Address = address;
            Age = age;
            ParentName = parentName;
            Email = email;
        }

        public void AddGrade(int grade)
        {
            Grades.Add(grade);
        }

        public double CalculateAverageGrade() 
        { 
            return Grades.Average(); 
        }

        public void PrintStudentInfo()
        {
            Console.WriteLine(Name,Address,Age,ParentName,Email);
        }

        public bool IsPassing()
        {
            return CalculateAverageGrade() > 2;
        }

        public void AddAdditionalGrade(int grade)
        {
            Grades.Add(grade);
        }

        public int GetHighestGrade()
        {
            int max = 0;
            foreach (int grade in Grades) 
            {
                if (grade > max)
                {
                    max = grade;
                }
            }
            return max;
        }
    }
}
