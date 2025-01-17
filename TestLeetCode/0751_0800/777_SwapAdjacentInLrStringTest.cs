using leetCode._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0751_0800
{
    [TestClass]
    public class _777_SwapAdjacentInLrStringTest
    {
        _777_SwapAdjacentInLrStringAlg alg = new _777_SwapAdjacentInLrStringAlg();

        [TestMethod]
        public void TestCase01()
        {
            string start = "RXXLRXRXL";
            string result = "XRLXXRRLX";
            bool exp = true;
            bool res = alg.CanTransform(start, result);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string start = "X";
            string result = "L";
            bool exp = false;
            bool res = alg.CanTransform(start, result);
            Assert.AreEqual(exp, res);
        }
    }
}
