namespace _10.Palindrome_Index
{
    using System;

    public class PalindromeIndex
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int problemIndex = -1;
            bool isPalindromeLeft = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != input[input.Length - 1 - i])//checking again whether it is a palindrome, we are looking for cases where it is not
                {
                    int left = i + 1;
                    //case when we remove the left one
                    for (; left < input.Length; left++)
                    {
                        if (input[left] != input[input.Length - left]) 
                        {
                            isPalindromeLeft = false;
                            break;
                        }
                    }

                    if (isPalindromeLeft)
                    {
                        problemIndex = i;
                        break;
                    }

                    //if it is not on the left side, then it is on the right
                    problemIndex = input.Length - left;
                }

                isPalindromeLeft = true;
            }

            Console.WriteLine(problemIndex);
        }
    }
}