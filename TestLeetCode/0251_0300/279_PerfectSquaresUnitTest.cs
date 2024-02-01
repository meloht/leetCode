using leetCode._0251_0300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0251_0300
{
    [TestClass]
    public class _279_PerfectSquaresUnitTest
    {
        _279_PerfectSquaresAlg alg = new _279_PerfectSquaresAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 12;
            int exp = 3;
            int res = alg.NumSquares(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 13;
            int exp = 2;
            int res = alg.NumSquares(n);
            Assert.AreEqual(exp, res);
        }
    }
}
