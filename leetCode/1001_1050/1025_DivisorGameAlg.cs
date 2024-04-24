using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{
    public class _1025_DivisorGameAlg
    {
        public bool DivisorGame(int n)
        {
            if (n % 2 == 1)
                return false;

            return true;
        }
    }
}
