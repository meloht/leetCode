using leetCode._2401_2450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2401_2450
{
    [TestClass]
    public class _2411_SmallestSubarraysWithMaximumBitwiseOrTest
    {
        _2411_SmallestSubarraysWithMaximumBitwiseOrAlg alg = new _2411_SmallestSubarraysWithMaximumBitwiseOrAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 0, 2, 1, 3];
            int[] exp = [3, 3, 2, 2, 1];
            int[] res = alg.SmallestSubarrays(nums);
            CollectionAssert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2];
            int[] exp = [2, 1];
            int[] res = alg.SmallestSubarrays(nums);
            CollectionAssert.AreEqual(exp, res);
        }
    }
}
