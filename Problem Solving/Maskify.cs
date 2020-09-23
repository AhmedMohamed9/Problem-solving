using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving
{
    class Maskify
    {
        public Maskify(string cc)
        {
            int len = cc.Length;
            if (len < 4)
                Console.WriteLine(cc);
            Console.WriteLine(cc.Substring(len - 4, 4).PadLeft(len, '#'));
            Console.ReadKey();
        }
    }
}
