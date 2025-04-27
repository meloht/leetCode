using leetCode._2401_2450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._2401_2450
{
    public class _2444_CountSubarraysWithFixedBoundsTest
    {
        _2444_CountSubarraysWithFixedBoundsAlg alg = new _2444_CountSubarraysWithFixedBoundsAlg();
        
        [Fact]
        public void Test01()
        {
            int[] nums = [1, 3, 5, 2, 7, 5];
            int minK = 1, maxK = 5;
            long exp = 2;
            long res = alg.CountSubarrays(nums, minK, maxK);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] nums = [1, 1, 1, 1];
            int minK = 1, maxK = 1;
            long exp = 10;
            long res = alg.CountSubarrays(nums, minK, maxK);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[] nums = [35054, 398719, 945315, 945315, 820417, 945315, 35054, 945315, 171832, 945315, 35054, 109750, 790964, 441974, 552913];
            int minK = 35054, maxK = 945315;
            long exp = 81;
            long res = alg.CountSubarrays(nums, minK, maxK);
            Assert.Equal(exp, res);
        }
    }
}
