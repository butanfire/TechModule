using System;
using System.Linq;

namespace _02.Matrix_of_Palindromes
{
    public class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int row = sizes[0];
            int cols = sizes[1];
            char letter = 'a';
            char middleLetter = 'a';
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    string output = letter + middleLetter.ToString() + letter;
                    Console.Write(output + " ");
                    middleLetter++;
                }

                Console.WriteLine();
                middleLetter = ++letter;
            }

            
        }
    }
}
