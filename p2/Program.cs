using System;

namespace p2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            if(str.Length > 20)
            {
                str = str.Substring(0, 20);
            }
            else if(str.Length < 20)
            {
                str = str.PadRight(20, '*');
            }
            Console.WriteLine(str);
        }
    }
}
