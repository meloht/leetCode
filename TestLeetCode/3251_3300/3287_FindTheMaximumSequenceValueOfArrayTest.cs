using leetCode._3251_3300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3251_3300
{
    [TestClass]
    public class _3287_FindTheMaximumSequenceValueOfArrayTest
    {
        _3287_FindTheMaximumSequenceValueOfArrayAlg alg = new _3287_FindTheMaximumSequenceValueOfArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [2, 6, 7];
            int k = 1;
            int exp = 5;
            int res = alg.MaxValue(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [4, 2, 5, 6, 7];
            int k = 2;
            int exp = 2;
            int res = alg.MaxValue(nums, k);
            Assert.AreEqual(exp, res);
        }
    }
}
