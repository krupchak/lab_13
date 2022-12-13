using System;
using static System.Net.Mime.MediaTypeNames;

namespace p3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            var input = email.Split('@');
            string username = input[0];
            string domain = input[1];

            string newEmail = null;
            for (int i = 0; i < username.Length; i++)
            {
                newEmail += "*";
            }
            newEmail = newEmail + '@' + domain;
            Console.WriteLine(newEmail);

            string text = Console.ReadLine();
            text = text.Replace(email, newEmail);
            Console.WriteLine("\n" + text);
        }
    }
}
