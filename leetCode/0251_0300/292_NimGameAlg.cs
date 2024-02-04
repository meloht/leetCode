using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0251_0300
{
    public class _292_NimGameAlg
    {
        public bool CanWinNim(int n)
        {
            int res = n % 4;
            if (res== 0)
            {
                return false;
            }
            return true;
        }
    }
}
