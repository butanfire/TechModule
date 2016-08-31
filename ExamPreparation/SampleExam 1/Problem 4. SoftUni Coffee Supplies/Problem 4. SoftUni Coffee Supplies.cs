namespace Problem_4.SoftUni_Coffee_Supplies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SoftUniCoffeeSupplies
    {
        public static void Main(string[] args)
        {
            var delim = Console.ReadLine().Split(' ').ToArray();
            var firstDelim = delim[0];
            var secondDelim = delim[1];
            Dictionary<string, string> personCoffeePreference = new Dictionary<string, string>();
            Dictionary<string, int> coffeeDictionary = new Dictionary<string, int>(); //coffeetype amount
            string input = Console.ReadLine();

            while (input != "end of info")
            {
                int indexOfDelimiter = 0;

                if (input.Contains(firstDelim))
                {
                    indexOfDelimiter = input.IndexOf(firstDelim);
                    var person = input.Substring(0, indexOfDelimiter);
                    var coffeeType = input.Substring(indexOfDelimiter + firstDelim.Length);

                    if (!coffeeDictionary.ContainsKey(coffeeType))
                        coffeeDictionary.Add(coffeeType, 0);
                    if (!personCoffeePreference.ContainsKey(person))
                    {
                        personCoffeePreference.Add(person, coffeeType);
                    }
                    else
                    {
                        personCoffeePreference[person] = coffeeType;
                    }
                    //person + coffee preference
                }
                else
                {
                    //coffee type + available number
                    indexOfDelimiter = input.IndexOf(secondDelim);
                    var coffeeType = input.Substring(0, indexOfDelimiter);
                    var amount = int.Parse(input.Substring(indexOfDelimiter + secondDelim.Length));

                    if (!coffeeDictionary.ContainsKey(coffeeType))
                    {
                        coffeeDictionary.Add(coffeeType, amount);
                    }
                    else
                    {
                        coffeeDictionary[coffeeType] += amount;
                    }
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "end of week")
            {
                var arguments = input.Split(' ').ToArray();
                var person = arguments[0];
                var coffee = personCoffeePreference.First(s => s.Key == person).Value;
                var consumption = int.Parse(arguments[1]);
                coffeeDictionary[coffee] -= consumption;
                input = Console.ReadLine();
            }

            //print the reports

            foreach (var coffee in coffeeDictionary.Where(s => s.Value <= 0))
            {
                Console.WriteLine("Out of {0}", coffee.Key);
            }

            Console.WriteLine("Coffee Left:");
            foreach (var coffee in coffeeDictionary.Where(s => s.Value > 0).OrderByDescending(s => s.Value))
            {
                Console.WriteLine("{0} {1}", coffee.Key, coffee.Value);
            }

            Console.WriteLine("For:");
            foreach (var coffee in personCoffeePreference
                .OrderBy(s => s.Value) //coffee
                .ThenByDescending(s => s.Key) //person
                .Where(coffee => coffeeDictionary[coffee.Value] > 0))
            {
                Console.WriteLine(coffee.Key + " " + coffee.Value);
            }
        }
    }
}
