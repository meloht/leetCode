using leetCode._1101_1150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1101_1150
{
    [TestClass]
    public class _1139_Largest1BorderedSquareTest
    {
        _1139_Largest1BorderedSquareAlg alg = new _1139_Largest1BorderedSquareAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] grid = [[1, 1, 1], [1, 0, 1], [1, 1, 1]];
            int exp = 9;
            int res = alg.Largest1BorderedSquare(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] grid = [[1, 1, 0, 0]];
            int exp = 1;
            int res = alg.Largest1BorderedSquare(grid);
            Assert.AreEqual(exp, res);
        }
    }
}
