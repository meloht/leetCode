using leetCode._3251_3300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3251_3300
{
    [TestClass]
    public class _3254_FindThePowerOfKSizeSubarraysITest
    {
        _3254_FindThePowerOfKSizeSubarraysIAlg alg = new _3254_FindThePowerOfKSizeSubarraysIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 3, 4, 3, 2, 5];
            int k = 3;
            int[] exp = [3, 4, -1, -1, -1];
            int[] res=alg.ResultsArray(nums, k);
            Assert.IsTrue(exp.SequenceEqual(res));

        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [2, 2, 2, 2, 2];
            int k = 4;
            int[] exp = [-1, -1];
            int[] res = alg.ResultsArray(nums, k);
            Assert.IsTrue(exp.SequenceEqual(res));

        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [3, 2, 3, 2, 3, 2];
            int k = 2;
            int[] exp = [-1, 3, -1, 3, -1];
            int[] res = alg.ResultsArray(nums, k);
            Assert.IsTrue(exp.SequenceEqual(res));

        }
    }
}
