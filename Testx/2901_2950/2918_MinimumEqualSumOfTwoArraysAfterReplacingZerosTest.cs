using leetCode._2901_2950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._2901_2950
{
    public class _2918_MinimumEqualSumOfTwoArraysAfterReplacingZerosTest
    {
        _2918_MinimumEqualSumOfTwoArraysAfterReplacingZerosAlg alg = new _2918_MinimumEqualSumOfTwoArraysAfterReplacingZerosAlg();

        [Fact]
        public void Test01()
        {
            int[] nums1 = [3, 2, 0, 1, 0], nums2 = [6, 5, 0];
            long exp = 12;
            long res = alg.MinSum(nums1, nums2);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] nums1 = [2, 0, 2, 0], nums2 = [1, 4];
            long exp = -1;
            long res = alg.MinSum(nums1, nums2);
            Assert.Equal(exp, res);
        }
    }
}
