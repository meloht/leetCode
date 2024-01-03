using leetCode._0701_0750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0701_0750
{
    [TestClass]
    public class _740_DeleteAndEarnUnitTest
    {
        _740_DeleteAndEarnAlg alg = new _740_DeleteAndEarnAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [3, 4, 2];
            int exp = 6;
            int res = alg.DeleteAndEarn(nums);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [2, 2, 3, 3, 3, 4];
            int exp = 9;
            int res = alg.DeleteAndEarn(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
