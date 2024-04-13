using leetCode._0601_0650;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0601_0650
{
    [TestClass]
    public class _628_MaximumProductOfThreeNumbersUnitTest
    {
        _628_MaximumProductOfThreeNumbersAlg alg = new _628_MaximumProductOfThreeNumbersAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 3];
            int exp = 6;
            int res = alg.MaximumProduct(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 3, 4];
            int exp = 24;
            int res = alg.MaximumProduct(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [-1, -2, -3];
            int exp = -6;
            int res = alg.MaximumProduct(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
