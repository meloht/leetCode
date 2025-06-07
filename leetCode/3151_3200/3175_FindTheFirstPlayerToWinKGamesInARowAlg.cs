using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3151_3200
{
    public class _3175_FindTheFirstPlayerToWinKGamesInARowAlg
    {
        public int FindWinningPlayer(int[] skills, int k)
        {
            int maxI = 0;
            int win = 0;
            for (int i = 1; i < skills.Length && win < k; i++)
            {
                if (skills[i] > skills[maxI])
                { // 打擂台，发现新的最大值
                    maxI = i;
                    win = 0;
                }
                win++; // 获胜回合 +1
            }
            // 如果 k 很大，那么 maxI 就是 skills 最大值的下标，毕竟最大值会一直赢下去
            return maxI;
        }
    }
}
