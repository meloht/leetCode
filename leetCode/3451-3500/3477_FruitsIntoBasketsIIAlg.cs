using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3451_3500
{
    public class _3477_FruitsIntoBasketsIIAlg
    {
        public int NumOfUnplacedFruits(int[] fruits, int[] baskets)
        {

            int ans = 0;
            for (int i = 0; i < fruits.Length; i++)
            {
                bool bl = false;
                for (int j = 0; j < fruits.Length; j++)
                {
                    if ( fruits[i]<= baskets[j])
                    {
                        baskets[j] = 0;
                        bl = true;
                        break;
                    }
                }
                if (!bl)
                {
                    ans++;
                }
            }
            return ans;
        }
    }
}
