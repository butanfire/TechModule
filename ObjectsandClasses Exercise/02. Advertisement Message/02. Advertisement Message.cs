using System;

namespace _02.Advertisement_Message
{
    public class AdvertisementMessage
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            var phrases = new[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            var events = new[]
            {
                "Now I feel good.", 
                "I have succeeded with this product.", 
                "Makes miracles. I am happy of the results!", 
                "I cannot believe but now I feel awesome.", 
                "Try it yourself, I am very satisfied.", 
                "I feel great!"
            };

            var author = new[]
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            var cities = new[]
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            Random output = new Random();

            //generating random messages
            for (int i = 0; i < input; i++)
            {
                int randPhrase = output.Next(0, phrases.Length);
                int randEvent = output.Next(0, events.Length);
                int randAuthor = output.Next(0, author.Length);
                int randTown = output.Next(0, cities.Length);

                Console.WriteLine("{0} {1} {2} - {3}",
                    phrases[randPhrase],
                    events[randEvent],
                    author[randAuthor],
                    cities[randTown]
                    );
            }
        }
    }
}
