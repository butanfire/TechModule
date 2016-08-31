using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_4__Population_Aggregation
{
    public class PopulationAggregation
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Dictionary<string, int> countries = new Dictionary<string, int>();
            Dictionary<string, long> towns = new Dictionary<string, long>();
            while (input != "stop")
            {
                var arguments = input.Split('\\').ToArray();
                arguments[0] = ClearString(arguments[0]);
                arguments[1] = ClearString(arguments[1]);

                if (char.IsUpper(arguments[0][0]))
                {
                    if (!countries.ContainsKey(arguments[0]))
                    {
                        countries.Add(arguments[0], 0);
                    }

                    if (!towns.ContainsKey(arguments[1]))
                    {
                        towns.Add(arguments[1], long.Parse(arguments[2]));
                    }

                    countries[arguments[0]] += 1;
                    towns[arguments[1]] = long.Parse(arguments[2]);
                }
                else
                {
                    if (!countries.ContainsKey(arguments[1]))
                    {
                        countries.Add(arguments[1], 0);
                    }

                    if (!towns.ContainsKey(arguments[0]))
                    {
                        towns.Add(arguments[0], long.Parse(arguments[2]));
                    }

                    countries[arguments[1]] += 1;
                    towns[arguments[0]] = long.Parse(arguments[2]);
                }

                input = Console.ReadLine();
            }

            foreach (var country in countries.OrderBy(s => s.Key))
            {
                Console.WriteLine("{0} -> {1}", country.Key, country.Value);

            }

            foreach (var town in towns.OrderByDescending(s => s.Value).Take(3))
            {
                Console.WriteLine("{0} -> {1}", town.Key, town.Value);
            }
        }

        private static string ClearString(string word)
        {
            StringBuilder result = new StringBuilder();
            foreach (char t in word.Where(t => char.IsLetter(t)))
            {
                result.Append(t.ToString());
            }

            return result.ToString();
        }
    }
}
