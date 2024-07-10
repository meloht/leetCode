using leetCode._2951_3000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2951_3000
{
    [TestClass]
    public class _2970_CountTheNumberOfIncremovableSubarraysITest
    {
        _2970_CountTheNumberOfIncremovableSubarraysIAlg alg = new _2970_CountTheNumberOfIncremovableSubarraysIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 3, 4];
            int exp = 10;
            int res = alg.IncremovableSubarrayCount(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [6, 5, 7, 8];
            int exp = 7;
            int res = alg.IncremovableSubarrayCount(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [8, 7, 6, 6];
            int exp = 3;
            int res = alg.IncremovableSubarrayCount(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
