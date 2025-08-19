using leetCode._2301_2350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2301_2350
{
    [TestClass]
    public class _2348_NumberOfZeroFilledSubarraysTest
    {
        _2348_NumberOfZeroFilledSubarraysAlg alg = new _2348_NumberOfZeroFilledSubarraysAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 3, 0, 0, 2, 0, 0, 4];

            long exp = 6;
            long res = alg.ZeroFilledSubarray(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [0, 0, 0, 2, 0, 0];

            long exp = 9;
            long res = alg.ZeroFilledSubarray(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [2, 10, 2019];

            long exp = 0;
            long res = alg.ZeroFilledSubarray(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
