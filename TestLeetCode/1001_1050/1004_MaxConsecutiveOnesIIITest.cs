using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1001_1050
{
    [TestClass]
    public class _1004_MaxConsecutiveOnesIIITest
    {
        _1004_MaxConsecutiveOnesIIIAlg alg = new _1004_MaxConsecutiveOnesIIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0];
            int K = 2;
            int exp = 6;
            int res = alg.LongestOnes(nums, K);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1];
            int K = 3;
            int exp = 10;
            int res = alg.LongestOnes(nums, K);
            Assert.AreEqual(exp, res);
        }
    }
}
