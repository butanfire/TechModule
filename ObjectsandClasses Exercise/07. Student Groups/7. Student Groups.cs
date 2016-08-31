using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _7.Student_Groups
{
    public class StudentGroups
    {
        static void Main(string[] args)
        {
            var towns = ReadTownsAndStudents(); //read and collect students and towns
            var groups = DistributeStudentsIntoGroups(towns); //assign students from the respective town into groups

            Console.WriteLine("Created {0} groups in {1} towns:", groups.Count, towns.Distinct().Count());
            towns = towns.OrderBy(s => s.Name).ToList();
            foreach (var town in towns)
            {
                foreach (var studentMails in groups.Where(s => s.Town == town).Select(@group => @group.Students.Select(student => student.Email).ToList()))
                {
                    Console.WriteLine("{0} => {1}", town.Name, string.Join(", ", studentMails));
                }
            }
        }

        public static List<Town> ReadTownsAndStudents()
        {
            int index = -1;
            var towns = new List<Town>();
            var input = Console.ReadLine();
            while (input != "End")
            {
                if (input.Contains("=>")) //if it is a town
                {
                    index++;
                    var arguments = input.Split("=>".ToCharArray()).ToList();
                    arguments.RemoveAll(s => s == ""); //removing empty entries from the split
                    var townName = arguments[0].Trim().Substring(0, arguments[0].Length - 1);
                    var seats = arguments[1].Trim().Substring(0, arguments[1].IndexOf("seats") - 2);

                    var town = new Town(townName, int.Parse(seats), new List<Student>());
                    towns.Add(town);

                }
                else //else it is a student
                {
                    var arguments = input.Split("| ".ToCharArray()).ToList();
                    arguments.RemoveAll(s => s == ""); //removing empty entries from the split
                    var date = DateTime.ParseExact(arguments[3], "d-MMM-yyyy", CultureInfo.InvariantCulture);
                    towns[index].Students.Add(
                        new Student(
                        arguments[0] + " " + //firstname
                        arguments[1], //lastname
                        arguments[2], //email
                        date)); //starting date
                }

                input = Console.ReadLine();
            }

            return towns;
        }

        public static List<Group> DistributeStudentsIntoGroups(List<Town> towns)
        {
            var groups = new List<Group>();

            foreach (var town in towns)
            {
                var students = town.Students.OrderBy(s => s.RegistrationDate).ThenBy(s => s.Name).ThenBy(s => s.Email).ToList();
                while (students.Any())
                {
                    var group = new Group(town, students.Take(town.SeatCount).ToList()); //take students from the list based on the seat count
                    students = students.Skip(group.Town.SeatCount).ToList(); //remove the students from the list, and iterate through the rest
                    groups.Add(group); 
                }
            }

            return groups;
        }
    }

    public class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }

        public Group(Town town, List<Student> students)
        {
            this.Town = town;
            this.Students = students;
        }
    }

    public class Student
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime RegistrationDate { get; set; }

        public Student(string name, string email, DateTime registrationDate)
        {
            this.Name = name;
            this.Email = email;
            this.RegistrationDate = registrationDate;
        }
    }

    public class Town
    {
        public string Name { get; set; }

        public int SeatCount { get; set; }

        public List<Student> Students { get; set; }

        public Town(string name, int seatCount, List<Student> students)
        {
            this.Name = name;
            this.SeatCount = seatCount;
            this.Students = students;
        }
    }

}
