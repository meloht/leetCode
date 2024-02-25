using leetCode._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0751_0800
{
    [TestClass]
    public class _765_CouplesHoldingHandsUnitTest
    {
        _765_CouplesHoldingHandsAlg alg = new _765_CouplesHoldingHandsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] row = [0, 2, 1, 3];
            int exp = 1;
            int res = alg.MinSwapsCouples(row);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] row = [3, 2, 0, 1];
            int exp = 0;
            int res = alg.MinSwapsCouples(row);
            Assert.AreEqual(exp, res);
        }

    }
}
