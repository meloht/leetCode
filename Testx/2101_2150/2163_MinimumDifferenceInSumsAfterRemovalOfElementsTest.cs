using leetCode._2101_2150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._2101_2150
{
    public class _2163_MinimumDifferenceInSumsAfterRemovalOfElementsTest
    {
        _2163_MinimumDifferenceInSumsAfterRemovalOfElementsAlg alg = new _2163_MinimumDifferenceInSumsAfterRemovalOfElementsAlg();

        [Fact]
        public void TestCase01()
        {
            int[] nums = [3, 1, 2];
            long exp = -1;
            long res = alg.MinimumDifference(nums);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void TestCase02()
        {
            int[] nums = [7, 9, 5, 8, 1, 3];
            long exp = 1;
            long res = alg.MinimumDifference(nums);
            Assert.Equal(exp, res);
        }
    }
}
