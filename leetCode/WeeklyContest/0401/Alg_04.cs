using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.WeeklyContest._0401
{
    public class Alg_04
    {
        public int MaxTotalReward(int[] rewardValues)
        {
            int[] nums =new HashSet<int>(rewardValues).ToArray();
            Array.Sort(nums);
            BigInteger f = BigInteger.One;
            foreach (var v in nums)
            {
                BigInteger mask = (BigInteger.One << v) - BigInteger.One;
                f = f | (f & mask) << v;
            }

            return (int)f.GetBitLength() - 1;
        }
    }
}
