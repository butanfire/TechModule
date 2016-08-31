using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Average_Grades
{
    public class AverageGrades
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());

            List<Student> studentList = new List<Student>();

            for (int i = 0; i < lines; i++)
            {
                var inputArgs = Console.ReadLine().Split(' ');
                studentList.Add(new Student(inputArgs[0]));
                for (int j = 1; j < inputArgs.Length; j++)
                {
                    studentList[i].Grades.Add(double.Parse(inputArgs[j]));
                }
            }


            foreach (var student in studentList.OrderBy(s => s.Name).ThenByDescending(s => s.AverageGrade).Where(student => student.AverageGrade >= 5.00))
            {
                Console.WriteLine("{0} -> {1:F2}", student.Name, student.AverageGrade);
            }

        }
    }

    internal class Student
    {
        public string Name { get; set; }

        public List<double> Grades { get; set; }

        public double AverageGrade => Grades.Average();

        public Student(string name)
        {
            this.Name = name;
            this.Grades = new List<double>();
        }
    }
}
