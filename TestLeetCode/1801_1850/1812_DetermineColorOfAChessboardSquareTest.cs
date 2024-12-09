using leetCode._1801_1850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1801_1850
{
    [TestClass]
    public class _1812_DetermineColorOfAChessboardSquareTest
    {
        _1812_DetermineColorOfAChessboardSquareAlg alg = new _1812_DetermineColorOfAChessboardSquareAlg();

        [TestMethod]
        public void TestCase01()
        {
            string coordinates = "a1";
            bool exp = false;
            bool res = alg.SquareIsWhite(coordinates);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string coordinates = "h3";
            bool exp = true;
            bool res = alg.SquareIsWhite(coordinates);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string coordinates = "c7";
            bool exp = false;
            bool res = alg.SquareIsWhite(coordinates);
            Assert.AreEqual(exp, res);
        }
    }
}
