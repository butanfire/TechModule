namespace _07.Change_to_Uppercase
{
    using System;

    public class UpperCase
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var upcaseStr = "<upcase>";
            var upcaseEndStr = "</upcase>";

            int upcaseStart = text.IndexOf(upcaseStr);
            while (upcaseStart != -1)
            {
                int upcaseEnd = text.IndexOf(upcaseEndStr);
                if (upcaseEnd != -1)
                {
                    int startIndex = upcaseStart + upcaseStr.Length;
                    var upcaseText = text.Substring(startIndex, upcaseEnd - startIndex);
                    upcaseText = upcaseText.ToUpperInvariant();
                    text = text.Remove(upcaseStart, upcaseText.Length + upcaseEndStr.Length + upcaseStr.Length);
                    text = text.Insert(upcaseStart, upcaseText);
                }

                upcaseStart = text.IndexOf(upcaseStr);
            }

            Console.WriteLine(text);
        }
    }
}
