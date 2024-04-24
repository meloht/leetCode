using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1001_1050
{
    [TestClass]
    public class _1030_MatrixCellsInDistanceOrderUnitTest
    {
        _1030_MatrixCellsInDistanceOrderAlg alg = new _1030_MatrixCellsInDistanceOrderAlg();

        [TestMethod]
        public void TestCase01()
        {
            int rows = 1, cols = 2, rCenter = 0, cCenter = 0;
            int[][] exp = [[0, 0], [0, 1]];
            int[][] res = alg.AllCellsDistOrder(rows, cols, rCenter, cCenter);
            bool bl = Utils.IsSame(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int rows = 2, cols = 2, rCenter = 0, cCenter = 1;
            int[][] exp = [[0, 1], [0, 0], [1, 1], [1, 0]];
            int[][] res = alg.AllCellsDistOrder(rows, cols, rCenter, cCenter);
            bool bl = Utils.IsSame(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            int rows = 2, cols = 3, rCenter = 1, cCenter = 2;
            int[][] exp = [[1, 2], [0, 2], [1, 1], [0, 1], [1, 0], [0, 0]];
            int[][] res = alg.AllCellsDistOrder(rows, cols, rCenter, cCenter);
            bool bl = Utils.IsSame(exp, res);
            Assert.IsTrue(bl);
        }
    }
}
