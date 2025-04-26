using leetCode._2551_2600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._2550_2600
{
    public class _2563_CountTheNumberOfFairPairsTest
    {
        _2563_CountTheNumberOfFairPairsAlg alg = new _2563_CountTheNumberOfFairPairsAlg();

        [Fact]
        public void Test01()
        {
            int[] nums = [0, 1, 7, 4, 4, 5];
            int lower = 3, upper = 6;
            long exp = 6;
            long res = alg.CountFairPairs(nums, lower, upper);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] nums = [1, 7, 9, 2, 5];
            int lower = 11, upper = 11;
            long exp = 1;
            long res = alg.CountFairPairs(nums, lower, upper);
            Assert.Equal(exp, res);
        }
    }
}
