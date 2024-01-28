using leetCode._0251_0300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0251_0300
{
    [TestClass]
    public class _287_FindTheDuplicateNumberUnitTest
    {
        _287_FindTheDuplicateNumberAlg alg = new _287_FindTheDuplicateNumberAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 3, 4, 2, 2];
            int exp = 2;
            int res = alg.FindDuplicate(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [3, 1, 3, 4, 2];
            int exp = 3;
            int res = alg.FindDuplicate(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [2, 2, 2, 2, 2];
            int exp = 2;
            int res = alg.FindDuplicate(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
