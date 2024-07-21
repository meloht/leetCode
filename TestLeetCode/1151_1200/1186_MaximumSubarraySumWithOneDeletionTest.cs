using leetCode._1151_1200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1151_1200
{
    [TestClass]
    public class _1186_MaximumSubarraySumWithOneDeletionTest
    {
        _1186_MaximumSubarraySumWithOneDeletionAlg alg = new _1186_MaximumSubarraySumWithOneDeletionAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] arr = [1, -2, 0, 3];
            int exp = 4;
            int res = alg.MaximumSum(arr);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] arr = [1, -2, -2, 3];
            int exp = 3;
            int res = alg.MaximumSum(arr);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] arr = [-1, -1, -1, -1];
            int exp = -1;
            int res = alg.MaximumSum(arr);
            Assert.AreEqual(exp, res);
        }
    }
}
