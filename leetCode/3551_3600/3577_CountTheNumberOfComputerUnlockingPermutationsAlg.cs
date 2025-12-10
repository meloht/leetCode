using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3551_3600
{
    public class _3577_CountTheNumberOfComputerUnlockingPermutationsAlg
    {
        public int CountPermutations(int[] complexity)
        {
            int MOD = 1_000_000_007;
            long ans = 1;
            for (int i = 1; i < complexity.Length; i++)
            {
                if (complexity[i] <= complexity[0])
                {
                    return 0;
                }
                ans = ans * i % MOD;
            }
            return (int)ans;

        }
    }
}
