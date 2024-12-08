using leetCode._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0751_0800
{
    [TestClass]
    public class _782_TransformToChessboardTest
    {
        _782_TransformToChessboardAlg alg = new _782_TransformToChessboardAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] board = [[0, 1, 1, 0], [0, 1, 1, 0], [1, 0, 0, 1], [1, 0, 0, 1]];
            int exp = 2;
            int res = alg.MovesToChessboard(board);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] board = [[0, 1], [1, 0]];
            int exp = 0;
            int res = alg.MovesToChessboard(board);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] board = [[1, 0], [1, 0]];
            int exp = -1;
            int res = alg.MovesToChessboard(board);
            Assert.AreEqual(exp, res);
        }
    }
}
