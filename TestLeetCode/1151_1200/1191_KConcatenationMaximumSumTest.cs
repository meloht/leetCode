using leetCode._1151_1200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1151_1200
{
    [TestClass]
    public class _1191_KConcatenationMaximumSumTest
    {
        _1191_KConcatenationMaximumSumAlg alg = new _1191_KConcatenationMaximumSumAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] arr = [1, 2];
            int k = 3;
            int exp = 9;
            int res = alg.KConcatenationMaxSum(arr, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] arr = [1, -2, 1];
            int k = 5;
            int exp = 2;
            int res = alg.KConcatenationMaxSum(arr, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] arr = [-1, -2];
            int k = 7;
            int exp = 0;
            int res = alg.KConcatenationMaxSum(arr, k);
            Assert.AreEqual(exp, res);
        }
    }
}
