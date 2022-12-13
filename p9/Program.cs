using System;

namespace p9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string[] words = str.Split(' ', '.', ',', '?', '!', ';'); 

            foreach (string word in words) 
            {
                string newWord = ""; 
                for (int i = 0; i < word.Length; i++) 
                {
                    newWord += word[i]; 
                    if (i == 0) newWord = newWord.ToUpper(); 
                }

                str = str.Replace(word, newWord); 
            }

            Console.WriteLine(str);
        }
    }
}
