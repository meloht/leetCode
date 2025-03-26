using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _837_New21GamTest
    {
        _837_New21GamAlg alg = new _837_New21GamAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 10, k = 1, maxPts = 10;
            double exp = 1.00000;
            double res = alg.New21Game(n, k, maxPts);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 6, k = 1, maxPts = 10;
            double exp = 0.60000;
            double res = alg.New21Game(n, k, maxPts);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 21, k = 17, maxPts = 10;
            double exp = 0.73278;
            double res = alg.New21Game(n, k, maxPts);
            Assert.AreEqual(exp, res);
        }
    }
}
