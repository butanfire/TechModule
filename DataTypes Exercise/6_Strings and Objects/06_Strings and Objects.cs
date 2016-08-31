namespace _6_Strings_and_Objects
{
    using System;

    public class StringsObjects
    {
        public static void Main(string[] args)
        {
            string Hello = Console.ReadLine();
            string World = Console.ReadLine();

            object HelloWorld = Hello + " " + World;

            string HiWorld = (string) HelloWorld;

            Console.WriteLine(HiWorld);
        }
    }
}
