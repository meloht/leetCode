using leetCode._0551_0600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0551_0600
{
    [TestClass]
    public class _560_SubarraySumEqualsKUnitTest
    {
        _560_SubarraySumEqualsKAlg alg = new _560_SubarraySumEqualsKAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 1, 1];
            int k = 2;
            int exp = 2;
            int res = alg.SubarraySum(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 3];
            int k = 3;
            int exp = 2;
            int res = alg.SubarraySum(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1];
            int k = 0;
            int exp = 0;
            int res = alg.SubarraySum(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [-1, -1, 1];
            int k = 0;
            int exp = 1;
            int res = alg.SubarraySum(nums, k);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase05()
        {
            int[] nums = [1, -1, 0];
            int k = 0;
            int exp = 3;
            int res = alg.SubarraySum(nums, k);
            Assert.AreEqual(exp, res);
        }
    }
}
