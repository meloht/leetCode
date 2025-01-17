using leetCode._3201_3250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3201_3250
{
    [TestClass]
    public class _3209_NumberOfSubarraysWithAndValueOfKTest
    {
        _3209_NumberOfSubarraysWithAndValueOfKAlg alg = new _3209_NumberOfSubarraysWithAndValueOfKAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 1, 1];
            int k = 1;
            long exp = 6;
            long res = alg.CountSubarrays(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 1, 2];
            int k = 1;
            long exp = 3;
            long res = alg.CountSubarrays(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 2, 3];
            int k = 2;
            long exp = 2;
            long res = alg.CountSubarrays(nums, k);
            Assert.AreEqual(exp, res);
        }
    }
}
