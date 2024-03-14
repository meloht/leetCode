using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _485_MaxConsecutiveOnesUnitTest
    {
        _485_MaxConsecutiveOnesAlg alg = new _485_MaxConsecutiveOnesAlg();
        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 1, 0, 1, 1, 1];
            int exp = 3;
            int res = alg.FindMaxConsecutiveOnes(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 0, 1, 1, 0, 1];
            int exp = 2;
            int res = alg.FindMaxConsecutiveOnes(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [0];
            int exp = 0;
            int res = alg.FindMaxConsecutiveOnes(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
