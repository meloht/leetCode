using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _470_ImplementRand10UsingRand7Alg
    {
        public int Rand101()
        {
            int row, col, idx;
            do
            {
                row = Rand7();
                col = Rand7();
                idx = col + (row - 1) * 7;
            } while (idx > 40);
            return 1 + (idx - 1) % 10;

        }

        public int Rand10()
        {
            int a, b, idx;
            while (true)
            {
                a = Rand7();
                b = Rand7();
                idx = b + (a - 1) * 7;
                if (idx <= 40)
                {
                    return 1 + (idx - 1) % 10;
                }
                a = idx - 40;
                b = Rand7();
                // get uniform dist from 1 - 63
                idx = b + (a - 1) * 7;
                if (idx <= 60)
                {
                    return 1 + (idx - 1) % 10;
                }
                a = idx - 60;
                b = Rand7();
                // get uniform dist from 1 - 21
                idx = b + (a - 1) * 7;
                if (idx <= 20)
                {
                    return 1 + (idx - 1) % 10;
                }
            }
        }



        Random random = new Random();
        private int Rand7()
        {
            return random.Next(1, 8);
        }
    }
}
