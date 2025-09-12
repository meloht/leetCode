using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3201_3250
{
    public class _3227_VowelsGameInAStringAlg
    {
        public bool DoesAliceWin(string s)
        {

            foreach (var item in s)
            {
                if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u')
                {
                    return true;
                }
            }

            return false;
        }
    }
}
