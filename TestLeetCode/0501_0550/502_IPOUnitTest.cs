using leetCode._0501_0550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0501_0550
{
    [TestClass]
    public class _502_IPOUnitTest
    {
        _502_IPOAlg alg = new _502_IPOAlg();

        [TestMethod]
        public void TestCase01()
        {
            int k = 2, w = 0;
            int[] profits = [1, 2, 3], capital = [0, 1, 1];
            int exp = 4;
            int res = alg.FindMaximizedCapital(k, w, profits, capital);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase02()
        {
            int k = 3, w = 0;
            int[] profits = [1, 2, 3], capital = [0, 1, 2];
            int exp = 6;
            int res = alg.FindMaximizedCapital(k, w, profits, capital);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase03()
        {
            int k = 1, w = 0;
            int[] profits = [1, 2, 3], capital = [0, 1, 2];
            int exp = 1;
            int res = alg.FindMaximizedCapital(k, w, profits, capital);
            Assert.AreEqual(exp, res);
        }
    }
}
