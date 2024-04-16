using leetCode._0701_0750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0701_0750
{
    [TestClass]
    public class _747_LargestNumberAtLeastTwiceOfOthersUnitTest
    {
        _747_LargestNumberAtLeastTwiceOfOthersAlg alg = new _747_LargestNumberAtLeastTwiceOfOthersAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [3, 6, 1, 0];
            int exp = 1;
            int res = alg.DominantIndex(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 3, 4];
            int exp = -1;
            int res = alg.DominantIndex(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
