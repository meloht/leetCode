using leetCode._2801_2850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._2801_2850
{
    public class _2845_CountOfInterestingSubarraysTest
    {
        _2845_CountOfInterestingSubarraysAlg alg = new _2845_CountOfInterestingSubarraysAlg();

        [Fact]
        public void Test01()
        {
            int[] nums = [3, 2, 4];
            int modulo = 2, k = 1;
            long exp = 3;
            long res=alg.CountInterestingSubarrays(nums, modulo, k);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] nums = [3, 1, 9, 6];
            int modulo = 3, k = 0;
            long exp = 2;
            long res = alg.CountInterestingSubarrays(nums, modulo, k);
            Assert.Equal(exp, res);
        }
    }
}
