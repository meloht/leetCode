using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _672_BulbSwitcherIIAlg
    {
        public int FlipLights(int n, int presses)
        {
            //不按开关
            if (presses == 0)
            {
                return 1;
            }
            //特殊情况处理
            if (n == 1)
            {
                return 2;
            }
            else if (n == 2)
            {
                //特殊情况
                return presses == 1 ? 3 : 4;
            }
            else
            {
                //n >= 3
                return presses == 1 ? 4 : presses == 2 ? 7 : 8;
            }

        }
    }
}
