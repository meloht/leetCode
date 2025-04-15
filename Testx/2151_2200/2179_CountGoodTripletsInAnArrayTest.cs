using leetCode._2151_2200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._2151_2200
{
    public class _2179_CountGoodTripletsInAnArrayTest
    {
        _2179_CountGoodTripletsInAnArrayAlg alg = new _2179_CountGoodTripletsInAnArrayAlg();

        [Fact]
        public void Test01()
        {
            int[] nums1 = [2, 0, 1, 3], nums2 = [0, 1, 2, 3];
            long exp = 1;
            long res = alg.GoodTriplets(nums1, nums2);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] nums1 = [4, 0, 1, 3, 2], nums2 = [4, 1, 0, 2, 3];
            long exp = 4;
            long res = alg.GoodTriplets(nums1, nums2);
            Assert.Equal(exp, res);
        }
    }
}
