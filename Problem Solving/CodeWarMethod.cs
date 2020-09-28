using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_Solving
{
    class CodeWarMethod
    {
        public static string ExpandedForm(long num)
        {
            //14
            string n_num = num.ToString();
            int l = n_num.Length;
            string result = string.Empty;
            foreach (var item in n_num)
            {
                if (item!='0')
                {
                    string n = item.ToString();
                    for (int i = 1; i < l; i++)
                    {
                       n = n + "0";
                    }
                    if (result == string.Empty)
                        result =  n;
                    else
                        result =result+' '+ "+"+' ' + n;
                }
                l--;
            }
            return (result);
        }
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            // Your brilliant solution goes here
            // It's possible to pass random tests in about a second ;)
            return a.Where(x => !b.Contains(x)).ToArray();
           
                
            
        }
        public static int Solution(int value)
        {
            // Magic Happens
            if (value<1)
                return 0;
            List<int> num = new List<int>();
            for (int i = 1; i < value; i++)
            {
                if (i%3==0||i%5==0)
                {
                    num.Add(i);
                }
            }
            
            return num.Sum();

        }
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            //your code here...

            var result = new List<T>();
            foreach (var item in iterable)
                if (!item.Equals(result.LastOrDefault()))
                    result.Add(item);
                
            
            return result;
        }
        public static string GetReadableTime(int seconds)
        {
            int sec = (seconds % 60);
            int min = ((seconds - sec) / 60) % 60;
            int hour = (seconds - sec - (60 * min)) / (60 * 60);

            return (hour.ToString("00") + ":" + min.ToString("00") + ":" + sec.ToString("00"));
        }
        public static long FindNextSquare(long num)
        {
            if (num>0)
            {
                var n = Math.Sqrt(num);
                if (n%1==0)
                {
                    return (long) Math.Pow(n + 1, 2);
                }
            }
            return -1;
            // your code here
        }
        public static long rowSumOddNumbers(long n)
        {
            // TODO
            long[] numbers = new long[n];
            long first_num = (n * n) - (n - 1);
            Console.WriteLine(first_num);
            for (int i = 0; i < n; i++)
            {
                numbers[i] = first_num;
                first_num += 2;
            }
            
            return numbers.Sum();
        }
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;

            // Your code here
            vowelCount = str.Count(a=>"aeiou".Contains(a));
            //vowelCount = str.ToCharArray()
            //    .Where(x=>x.ToString()=="a"
            //    ||x.ToString()=="e"
            //    || x.ToString() == "i"
            //    ||x.ToString() == "o"
            //    ||x.ToString() == "u")
            //    .Count();
            return vowelCount;
        }
    }
}
