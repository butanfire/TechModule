namespace _5_Boolean_Variable
{
    using System;

    public class BooleanVariable
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLowerInvariant();

            Console.WriteLine(input == "true" ? "Yes" : "No");
        }
    }
}
