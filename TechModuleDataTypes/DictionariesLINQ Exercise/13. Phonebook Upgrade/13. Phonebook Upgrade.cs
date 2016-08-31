namespace _13.Phonebook_Upgrade
{
    using System;
    using System.Collections.Generic;

    public class PhonebookUpgrade
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Dictionary<string, string> phoneDictionary = new Dictionary<string, string>();
            SortedSet<string> contacts = new SortedSet<string>();
            while (input != "END")
            {
                string[] commands = input.Split(' ');
                string name = string.Empty;
                string phone = string.Empty;
                if (commands[0] == "A")
                {
                    name = commands[1];
                    phone = commands[2];
                    contacts.Add(name);

                    if (!phoneDictionary.ContainsKey(name))
                    {
                        phoneDictionary.Add(name, phone);
                    }
                    else
                    {
                        phoneDictionary.Remove(name);
                        phoneDictionary.Add(name, phone);
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
                        Console.WriteLine("Contact {0} does not exist.", name);
                    }
                }

                if (commands[0] == "ListAll")
                {
                    foreach (var contact in contacts)
                    {
                        Console.WriteLine("{0} -> {1}", contact, phoneDictionary[contact]);
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
