using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving
{
    class find_it
    {
        public find_it(int[] seq)
        {
            var odd = seq.Select(a => a%2 != 0).GroupBy(s=>s).Select(s=>s.Count()>1);
            Console.WriteLine(odd);

        }
    }
}
