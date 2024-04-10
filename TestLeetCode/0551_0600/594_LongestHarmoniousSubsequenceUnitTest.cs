using leetCode._0551_0600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0551_0600
{
    [TestClass]
    public class _594_LongestHarmoniousSubsequenceUnitTest
    {
        _594_LongestHarmoniousSubsequenceAlg alg = new _594_LongestHarmoniousSubsequenceAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 3, 2, 2, 5, 2, 3, 7];
            int exp = 5;
            int res = alg.FindLHS(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 3, 4];
            int exp = 2;
            int res = alg.FindLHS(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 1, 1, 1];
            int exp = 0;
            int res = alg.FindLHS(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
