using System;
using System.Collections.Generic;
using System.Linq;

namespace p4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string[] text = Console.ReadLine().Split('.', '!', '?');

            List<string> newText = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Contains(word))
                {
                    string[] t = text[i].Split(' ');

                    if (t.Contains(word));
                    newText.Add(text[i].Trim());
                }
            }

                Console.WriteLine();
            foreach (string s in newText)
                Console.WriteLine(s);
        }
    }
}
