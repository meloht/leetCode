using leetCode._1301_1350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1301_1350
{
    [TestClass]
    public class _1329_SortTheMatrixDiagonallyUnitTest
    {
        _1329_SortTheMatrixDiagonallyAlg alg = new _1329_SortTheMatrixDiagonallyAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] mat = [[3, 3, 1, 1], [2, 2, 1, 2], [1, 1, 1, 2]];
            int[][] exp = [[1, 1, 1, 1], [1, 2, 2, 2], [1, 2, 3, 3]];
            int[][] res = alg.DiagonalSort(mat);
            bool bl = Utils.IsSameList(res, exp);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] mat = [[11, 25, 66, 1, 69, 7], [23, 55, 17, 45, 15, 52], [75, 31, 36, 44, 58, 8], [22, 27, 33, 25, 68, 4], [84, 28, 14, 11, 5, 50]];
            int[][] exp = [[5, 17, 4, 1, 52, 7], [11, 11, 25, 45, 8, 69], [14, 23, 25, 44, 58, 15], [22, 27, 31, 36, 50, 66], [84, 28, 75, 33, 55, 68]];
            int[][] res = alg.DiagonalSort(mat);
            bool bl = Utils.IsSameList(res, exp);
            Assert.IsTrue(bl);
        }
    }
}
