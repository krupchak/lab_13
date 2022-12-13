using System;
using System.Collections.Generic;

namespace p7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            List<string> newText = new List<string>();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '<' && text[i + 1] == 'u' && text[i + 2] == 'p' && text[i + 3] == 'c' && text[i + 4] == 'a' && text[i + 5] == 's' && text[i + 6] == 'e' && text[i + 7] == '>') 
                {
                    string str = "";
                    for (int j = i + 8; j < text.Length; j++)
                    {
                        str += text[j];
                            if (text[j + 1] == '<' && text[j + 2] == '/' && text[j + 3] == 'u' && text[j + 4] == 'p' && text[j + 5] == 'c' && text[j + 6] == 'a' && text[j + 7] == 's' && text[j + 8] == 'e' && text[j + 9] == '>') 
                            { i = j; break; }
                    }
                    newText.Add(str);
                }
            }
            foreach (string t in newText) 
                if (text.Contains(t)) 
                    text = text.Replace(t, t.ToUpper());

            text = text.Replace("<upcase>", ""); 
            text = text.Replace("</upcase>", "");

            Console.WriteLine(text); 
        }
    }
}
