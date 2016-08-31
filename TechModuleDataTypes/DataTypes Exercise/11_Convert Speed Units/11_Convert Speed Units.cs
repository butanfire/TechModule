namespace _11_Convert_Speed_Units
{
    using System;

    public class ConvertSpeedUnits
    {
        public static void Main(string[] args)
        {
            int meteres = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float kilometers = (float)meteres/1000;
            float miles = (float) meteres /1609;

            int totalSeconds = (hours * 3600) + (minutes*60) + seconds;
            float totalHours = hours + (float)minutes/60 + (float)seconds/3600;

            float mps = (float)meteres / totalSeconds;
            float kmh = kilometers /totalHours;
            float mph = miles /totalHours;

            Console.WriteLine("{0}\n{1}\n{2}",mps,kmh,mph);
        }
    }
}
