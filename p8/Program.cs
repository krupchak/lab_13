using System;
using System.Collections.Generic;
using System.Linq;

namespace p8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ', ',', '.', ':', '?', '!');
            List<string> word = new List<string>();
            List<string> palindromes = new List<string>();

            for(int i = 0; i < text.Length; i++)
            {
                word.Add(text[i]);
            }

            foreach(var w in word)
            {
                bool a;
                for(int i = 0; i < w.Length / 2; i++)
                {
                    if (w[i] == w[w.Length - 1 - i])
                        a = true;
                    else
                        a = false;
                }
                if(a) palindromes.Add(w);
            }

            palindromes.Sort();
            foreach(string p in palindromes)
            Console.WriteLine(p);
        }
    }
}
