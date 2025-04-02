using leetCode._0851_0900;
using leetCode.WeeklyContest._0401;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0851_0900
{
    public class _870_AdvantageShuffleTest
    {
        _870_AdvantageShuffleAlg alg = new _870_AdvantageShuffleAlg();
        [Fact]
        public void Test01()
        {
            int[] nums1 = [2, 7, 11, 15], nums2 = [1, 10, 4, 11];
            int[] exp = [2, 11, 7, 15];
            int[] res= alg.AdvantageCount(nums1, nums2);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] nums1 = [12, 24, 8, 32], nums2 = [13, 25, 32, 11];
            int[] exp = [24, 32, 8, 12];
            int[] res = alg.AdvantageCount(nums1, nums2);
            Assert.Equal(exp, res);
        }
    }
}
