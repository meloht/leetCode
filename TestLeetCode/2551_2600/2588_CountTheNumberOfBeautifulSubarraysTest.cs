using leetCode._2551_2600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2551_2600
{
    [TestClass]
    public class _2588_CountTheNumberOfBeautifulSubarraysTest
    {
        _2588_CountTheNumberOfBeautifulSubarraysAlg alg = new _2588_CountTheNumberOfBeautifulSubarraysAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [4, 3, 1, 2, 4];
            long exp = 2;
            long res = alg.BeautifulSubarrays(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 10, 4];
            long exp = 0;
            long res = alg.BeautifulSubarrays(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
