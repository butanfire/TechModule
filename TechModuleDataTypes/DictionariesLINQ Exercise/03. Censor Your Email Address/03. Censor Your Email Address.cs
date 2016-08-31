namespace _03.Censor_Your_Email_Address
{
    using System;
    using System.Linq;

    public class CensorEmail
    {
        static void Main(string[] args)
        {
            var inputMail = Console.ReadLine().Split('@').ToArray();
            var text = Console.ReadLine();

            string user = inputMail[0];
            string mail = inputMail[1];

            text = text.Replace(user + "@" + mail, new string('*', user.Length) + "@" + mail);

            Console.WriteLine(text);
        }
    }
}
