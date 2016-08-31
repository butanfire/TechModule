namespace _1_Practice_Integer_Numbers
{
    using System;

    public class PracticeIntegerNumbers
    {
        public static void Main(string[] args)
        {
            sbyte sbyteVar = sbyte.Parse(Console.ReadLine());
            byte byteVar = byte.Parse(Console.ReadLine());
            short shortVar = short.Parse(Console.ReadLine());
            ushort ushortVar = ushort.Parse(Console.ReadLine());
            uint uintVar = uint.Parse(Console.ReadLine());
            int intVar = int.Parse(Console.ReadLine());
            long longVar = long.Parse(Console.ReadLine());

            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n",sbyteVar,byteVar,shortVar,ushortVar,uintVar, intVar, longVar);
        }
    }
}
