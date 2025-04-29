using leetCode._2951_3000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._2951_3000
{
    public class _2962_CountSubarraysWhereMaxElementAppearsAtLeastKTimesTest
    {

        _2962_CountSubarraysWhereMaxElementAppearsAtLeastKTimesAlg alg = new _2962_CountSubarraysWhereMaxElementAppearsAtLeastKTimesAlg();

        [Fact]
        public void Test01()
        {
            int[] nums = [1, 3, 2, 3, 3];
            int k = 2;
            long exp = 6;
            long res = alg.CountSubarrays(nums, k);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] nums = [1, 4, 2, 1];
            int k = 3;
            long exp = 0;
            long res = alg.CountSubarrays(nums, k);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[] nums = [61, 23, 38, 23, 56, 40, 82, 56, 82, 82, 82, 70, 8, 69, 8, 7, 19, 14, 58, 42, 82, 10, 82, 78, 15, 82];
            int k = 2;
            long exp = 224;
            long res = alg.CountSubarrays(nums, k);
            Assert.Equal(exp, res);
        }
    }
}
