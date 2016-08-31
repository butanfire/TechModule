namespace Problem_2.SoftUni_Water_Supplies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SoftUniWaterSupplies
    {
        static void Main(string[] args)
        {
            decimal waterLiters = decimal.Parse(Console.ReadLine());
            var bottles = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            var bottleCapacity = decimal.Parse(Console.ReadLine());
            decimal remainingWater = waterLiters;
            
            var enoughWater = true;
            long index = 0;
            var indexesLeft = new List<long>();

            if (waterLiters % 2 == 0)
            {
                for (index = 0; index < bottles.Length; index++)
                {
                    decimal waterNeeded = Math.Abs(bottleCapacity - bottles[index]);

                    if (waterNeeded > remainingWater)
                    {
                        enoughWater = false;
                        break;
                    }

                    remainingWater -= waterNeeded;
                }
                
                if (!enoughWater)
                {
                    for (; index < bottles.Length; index++)
                    {
                        indexesLeft.Add(index);
                    }
                }
            }
            else
            {
                for (index = bottles.Length - 1; index >= 0; index--)
                {
                    decimal waterNeeded = Math.Abs(bottleCapacity - bottles[index]);
                    if (waterNeeded > remainingWater)
                    {
                        enoughWater = false;
                        break;
                    }

                    remainingWater -= waterNeeded;
                }

                if (!enoughWater)
                {
                    for (; index >= 0; index--)
                    {
                        indexesLeft.Add(index);
                    }
                }
            }
            
            if (enoughWater)
            {
                Console.WriteLine("Enough water!\nWater left: {0}l.", remainingWater);
            }
            else
            {
                decimal waterLeft = indexesLeft.Sum(bottleIndex => bottleCapacity - bottles[bottleIndex]);
                remainingWater -= waterLeft;
                Console.WriteLine("We need more water!\nBottles left: {0}\nWith indexes: {1}\nWe need {2} more liters!", 
                    indexesLeft.Count, 
                    string.Join(", ", indexesLeft), 
                    Math.Abs(remainingWater));
            }
        }
    }
}
