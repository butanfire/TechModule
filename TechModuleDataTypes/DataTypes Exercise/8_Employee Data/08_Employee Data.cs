namespace _8_Employee_Data
{
    using System;

    public class EmployeeData
    {
        public static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            string personalID = Console.ReadLine();
            long empID = long.Parse(Console.ReadLine());

            Console.WriteLine("First name: {0}\nLast name: {1}\nAge: {2}\nGender: {3}\nPersonal ID: {4}\nUnique Employee number: {5}",
                firstName, lastName, age, gender, personalID, empID);
        }
    }
}
