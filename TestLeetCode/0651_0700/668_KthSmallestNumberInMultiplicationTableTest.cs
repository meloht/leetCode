using leetCode._0651_0700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0651_0700
{
    [TestClass]
    public class _668_KthSmallestNumberInMultiplicationTableTest
    {
        _668_KthSmallestNumberInMultiplicationTableAlg alg = new _668_KthSmallestNumberInMultiplicationTableAlg();

        [TestMethod]
        public void TestCase01()
        {
            int m = 3, n = 3, k = 5;
            int exp = 3;
            int res = alg.FindKthNumber(m, n, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int m = 2, n = 3, k = 6;
            int exp = 6;
            int res = alg.FindKthNumber(m, n, k);
            Assert.AreEqual(exp, res);
        }
    }
}
