using leetCode._1201_1250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1201_1250
{
    [TestClass]
    public class _1248_CountNumberOfNiceSubarraysTest
    {
        _1248_CountNumberOfNiceSubarraysAlg alg = new _1248_CountNumberOfNiceSubarraysAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 1, 2, 1, 1];
            int k = 3;
            int exp = 2;
            int res = alg.NumberOfSubarrays(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [2, 4, 6];
            int k = 1;
            int exp = 0;
            int res = alg.NumberOfSubarrays(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [2, 2, 2, 1, 2, 2, 1, 2, 2, 2];
            int k = 2;
            int exp = 16;
            int res = alg.NumberOfSubarrays(nums, k);
            Assert.AreEqual(exp, res);
        }
    }
}
