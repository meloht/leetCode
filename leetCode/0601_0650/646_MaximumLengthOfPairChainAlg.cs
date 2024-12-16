using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0601_0650
{
    public class _646_MaximumLengthOfPairChainAlg
    {
        public int FindLongestChain(int[][] pairs)
        {
            Array.Sort(pairs, (x, y) => x[1].CompareTo(y[0]));


            return 0;
        }


        private int Dfs(int i,int j, int[][] pairs)
        {
            if (i == 0)
            {
                
            }
   
            if (pairs[i][1] < pairs[i][0])
            {
               // Dfs(i-1,i,pairs)+1
            }

            return 0;
        }
    }
}
