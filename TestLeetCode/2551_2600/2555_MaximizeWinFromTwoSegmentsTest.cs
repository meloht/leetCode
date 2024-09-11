using leetCode._2551_2600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2551_2600
{
    [TestClass]
    public class _2555_MaximizeWinFromTwoSegmentsTest
    {
        _2555_MaximizeWinFromTwoSegmentsAlg alg = new _2555_MaximizeWinFromTwoSegmentsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] prizePositions = [1, 1, 2, 2, 3, 3, 5];
            int k = 2;
            int exp = 7;
            int res = alg.MaximizeWin(prizePositions, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] prizePositions = [1, 2, 3, 4];
            int k = 0;
            int exp = 2;
            int res = alg.MaximizeWin(prizePositions, k);
            Assert.AreEqual(exp, res);
        }
    }
}
