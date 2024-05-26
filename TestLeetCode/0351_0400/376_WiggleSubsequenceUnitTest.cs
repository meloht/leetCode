using leetCode._0351_0400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0351_0400
{
    [TestClass]
    public class _376_WiggleSubsequenceUnitTest
    {
        _376_WiggleSubsequenceAlg alg = new _376_WiggleSubsequenceAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 7, 4, 9, 2, 5];
            int exp = 6;
            int res = alg.WiggleMaxLength(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 17, 5, 10, 13, 15, 10, 5, 16, 8];
            int exp = 7;
            int res = alg.WiggleMaxLength(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9];
            int exp = 2;
            int res = alg.WiggleMaxLength(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
