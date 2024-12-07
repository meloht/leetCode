using leetCode._0651_0700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0651_0700
{
    [TestClass]
    public class _688_KnightProbabilityInChessboardTest
    {
        _688_KnightProbabilityInChessboardAlg alg = new _688_KnightProbabilityInChessboardAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 3, k = 2, row = 0, column = 0;
            double exp = 0.0625;
            double res = alg.KnightProbability(n, k, row, column);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 1, k = 0, row = 0, column = 0;
            double exp = 1.00000;
            double res = alg.KnightProbability(n, k, row, column);
            Assert.AreEqual(exp, res);
        }
    }
}
