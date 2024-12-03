using leetCode._3251_3300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3251_3300
{
    [TestClass]
    public class _3274_CheckIfTwoChessboardSquaresHaveTheSameColorTest
    {
        _3274_CheckIfTwoChessboardSquaresHaveTheSameColorAlg alg = new _3274_CheckIfTwoChessboardSquaresHaveTheSameColorAlg();
        [TestMethod]
        public void TestCase01()
        {
            string coordinate1 = "a1", coordinate2 = "c3";
            bool exp = true;
            bool res = alg.CheckTwoChessboards(coordinate1, coordinate2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string coordinate1 = "a1", coordinate2 = "h3";
            bool exp = false;
            bool res = alg.CheckTwoChessboards(coordinate1, coordinate2);
            Assert.AreEqual(exp, res);
        }
    }
}
