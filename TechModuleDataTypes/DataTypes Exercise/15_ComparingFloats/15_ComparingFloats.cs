namespace _15_ComparingFloats
{
    using System;

    public class ComparingFloats
    {
        public static void Main(string[] args)
        {
            decimal number1 = decimal.Parse(Console.ReadLine());
            //converting all numbers to decimal in order to precisely compare them
            decimal number2 = decimal.Parse(Console.ReadLine());
            //converting all numbers to decimal in order to precisely compare them
            decimal result = 0.0M; //result for comparison
            decimal eps = 0.000001M; //eps for precision

            //if we use double or float the task is not possible to complete correctly, because in the border case - the precision is not correct.
            
            if (number1 < 0) //if the number is negative - convert it to positive
            {
                number1 = 0 - number1;
            }
            if (number2 < 0) //if the number is negative - convert it to positive
            {
                number2 = 0 - number2;
            }
            if (number1 > number2)
            {
                //check if number 1 is bigger , then extract from the higher number)
                result = number1 - number2;
            }
            else
            {
                result = number2 - number1;
            } //otherwise extract from other number

            if (result < 0)
            {
                result = 0 - result;
            } //if result is negative, convert it to positive

            if (result - eps == 0) //if the result is equal to eps , then this is a border case and they are not equal
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(result < eps);
            }
            //if the difference/result is less than eps, then they are considered equal.
            //if it is not less than eps, then they are not equal

        }
    }
}
