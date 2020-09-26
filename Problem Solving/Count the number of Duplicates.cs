using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving
{
    class Count_the_number_of_Duplicates
    {
        public Count_the_number_of_Duplicates(string word)
        {
            var chars= word.ToLower().ToCharArray();
            Dictionary<char, int> duplicate_count = new Dictionary<char, int>();
            foreach (var item in chars)
            {
                if (duplicate_count.ContainsKey(item))
                {
                    duplicate_count[item] = duplicate_count[item] + 1;
                }
                else
                {
                    duplicate_count.Add(item, 1);
                }
            }
            int count = 0;
            foreach (var item in duplicate_count)
            {
                if (item.Value>1)
                {
                    count += 1; 
                }
                
            }
            Console.WriteLine(count);
        }
    }
}
