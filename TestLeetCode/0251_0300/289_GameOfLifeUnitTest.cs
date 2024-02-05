using leetCode._0251_0300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0251_0300
{
    [TestClass]
    public class _289_GameOfLifeUnitTest
    {
        _289_GameOfLifeAlg alg = new _289_GameOfLifeAlg();
        [TestMethod]
        public void TestCase01()
        {
            int[][] board = [[0, 1, 0], [0, 0, 1], [1, 1, 1], [0, 0, 0]];
            int[][] exp = [[0, 0, 0], [1, 0, 1], [0, 1, 1], [0, 1, 0]];
            alg.GameOfLife(board);
            bool bl = Utils.IsSameArr(exp, board);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] board = [[1, 1], [1, 0]];
            int[][] exp = [[1, 1], [1, 1]];
            alg.GameOfLife(board);
            bool bl = Utils.IsSameArr(exp, board);
            Assert.IsTrue(bl);
        }
    }
}
