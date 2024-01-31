using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2401_2450
{
    public class _2413_SmallestEvenMultipleAlg
    {
        public int SmallestEvenMultiple(int n)
        {
            if (n % 2 == 0)
                return n;
            return n * 2;
           
        }
       
    }
}
