namespace _12.Phonebook
{
    using System;
    using System.Collections.Generic;

    public class Phonebook
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Dictionary<string,string> phoneDictionary = new Dictionary<string, string>();
            while (input != "END")
            {
                string[] commands = input.Split(' ');
                string name = string.Empty;
                string phone = string.Empty;

                if (commands[0] == "A")
                {
                    name = commands[1];
                    phone = commands[2];

                    if (!phoneDictionary.ContainsKey(name))
                    {
                        phoneDictionary.Add(name, phone);
                    }
                    else
                    {
                        phoneDictionary.Remove(name);
                        phoneDictionary.Add(name,phone);
                    }
                }

                if (commands[0] == "S")
                {
                    name = commands[1];

                    if (phoneDictionary.ContainsKey(name))
                    {
                        Console.WriteLine("{0} -> {1}", name, phoneDictionary[name]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.",name);
                    }

                }

                input = Console.ReadLine();
            }
        }
    }
}
