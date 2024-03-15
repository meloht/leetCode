using leetCode._1501_1550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1501_1550
{
    [TestClass]
    public class _1539_KthMissingPositiveNumberUnitTest
    {
        _1539_KthMissingPositiveNumberAlg alg = new _1539_KthMissingPositiveNumberAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] arr = [2, 3, 4, 7, 11];
            int k = 5;
            int exp = 9;
            int res = alg.FindKthPositive(arr, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] arr = [1, 2, 3, 4];
            int k = 2;
            int exp = 6;
            int res = alg.FindKthPositive(arr, k);
            Assert.AreEqual(exp, res);
        }
    }
}
