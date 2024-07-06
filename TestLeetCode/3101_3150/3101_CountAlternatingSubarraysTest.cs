using leetCode._3101_3150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3101_3150
{
    [TestClass]
    public class _3101_CountAlternatingSubarraysTest
    {
        _3101_CountAlternatingSubarraysAlg alg = new _3101_CountAlternatingSubarraysAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [0, 1, 1, 1];
            long exp = 5;
            long res = alg.CountAlternatingSubarrays(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 0, 1, 0];
            long exp = 10;
            long res = alg.CountAlternatingSubarrays(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
