using leetCode._2551_2600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2551_2600
{
    [TestClass]
    public class _2597_TheNumberOfBeautifulSubsetsTest
    {
        _2597_TheNumberOfBeautifulSubsetsAlg alg = new _2597_TheNumberOfBeautifulSubsetsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [2, 4, 6];
            int k = 2;
            int exp = 4;
            int res = alg.BeautifulSubsets(nums, k);
            Assert.AreEqual(exp, res);

        }
        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1];
            int k = 1;
            int exp = 1;
            int res = alg.BeautifulSubsets(nums, k);
            Assert.AreEqual(exp, res);

        }
    }
}
