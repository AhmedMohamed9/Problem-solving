using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving
{
    class Spin_Word
    {
        public Spin_Word()
        {
            string word = Console.ReadLine();
            word = word.Trim();
            string[] words = word.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 4)
                {
                    words[i] = spinword(words[i]);
                }
            }
            word = string.Empty;
            foreach (var item in words)
            {
                word = word + ' ' + item;
            }
            Console.WriteLine(word.Trim());
            Console.ReadLine();
        }
        
        public static string spinword(string sentence)
        {
            int len = sentence.Length;
            string s = "";
            for (int i = 0; i < len; i++)
            {
                s = string.Concat(s, sentence[len - 1 - i]);
            };

            return s;
        }


    }
}
