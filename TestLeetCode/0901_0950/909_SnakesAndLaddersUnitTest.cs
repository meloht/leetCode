using leetCode._0901_0950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0901_0950
{
    [TestClass]
    public class _909_SnakesAndLaddersUnitTest
    {
        _909_SnakesAndLaddersAlg alg = new _909_SnakesAndLaddersAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] board = [
                [-1, -1, -1, -1, -1, -1],
                [-1, -1, -1, -1, -1, -1],
                [-1, -1, -1, -1, -1, -1],
                [-1, 35, -1, -1, 13, -1],
                [-1, -1, -1, -1, -1, -1],
                [-1, 15, -1, -1, -1, -1]];
            int exp = 4;
            int res = alg.SnakesAndLadders(board);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] board = [[-1, -1], [-1, 3]];
            int exp = 1;
            int res = alg.SnakesAndLadders(board);
            Assert.AreEqual(exp, res);
        }
    }
}
