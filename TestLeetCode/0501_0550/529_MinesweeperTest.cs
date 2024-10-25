using leetCode._0501_0550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0501_0550
{
    [TestClass]
    public class _529_MinesweeperTest
    {
        _529_MinesweeperAlg alg = new _529_MinesweeperAlg();

        [TestMethod]
        public void TestCase01()
        {
            char[][] board = [['E', 'E', 'E', 'E', 'E'], ['E', 'E', 'M', 'E', 'E'], ['E', 'E', 'E', 'E', 'E'], ['E', 'E', 'E', 'E', 'E']];
            int[] click = [3, 0];
            char[][] exp = [['B', '1', 'E', '1', 'B'], ['B', '1', 'M', '1', 'B'], ['B', '1', '1', '1', 'B'], ['B', 'B', 'B', 'B', 'B']];
            char[][] res = alg.UpdateBoard(board, click);
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            char[][] board = [['B', '1', 'E', '1', 'B'], ['B', '1', 'M', '1', 'B'], ['B', '1', '1', '1', 'B'], ['B', 'B', 'B', 'B', 'B']];
            int[] click = [1, 2];
            char[][] exp = [['B', '1', 'E', '1', 'B'], ['B', '1', 'X', '1', 'B'], ['B', '1', '1', '1', 'B'], ['B', 'B', 'B', 'B', 'B']];
            char[][] res = alg.UpdateBoard(board, click);
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);
        }
    }
}
