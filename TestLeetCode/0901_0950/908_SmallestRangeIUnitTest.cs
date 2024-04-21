using leetCode._0901_0950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0901_0950
{
    [TestClass]
    public class _908_SmallestRangeIUnitTest
    {
        _908_SmallestRangeIAlg alg = new _908_SmallestRangeIAlg();
        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1];
            int k = 0;
            int exp = 0;
            int res = alg.SmallestRangeI(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [0, 10];
            int k = 2;
            int exp = 6;
            int res = alg.SmallestRangeI(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 3, 6];
            int k = 3;
            int exp = 0;
            int res = alg.SmallestRangeI(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [3, 1, 10];
            int k = 4;
            int exp = 1;
            int res = alg.SmallestRangeI(nums, k);
            Assert.AreEqual(exp, res);
        }
    }
}
