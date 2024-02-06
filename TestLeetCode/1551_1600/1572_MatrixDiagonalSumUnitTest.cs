using leetCode._1551_1600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1551_1600
{
    [TestClass]
    public class _1572_MatrixDiagonalSumUnitTest
    {
        _1572_MatrixDiagonalSumAlg alg = new _1572_MatrixDiagonalSumAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] mat = [[1, 2, 3],
                [4, 5, 6],
                [7, 8, 9]];
            int exp = 25;
            int res = alg.DiagonalSum(mat);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] mat = [[1, 1, 1, 1],
                [1, 1, 1, 1],
                [1, 1, 1, 1],
                [1, 1, 1, 1]];
            int exp = 8;
            int res = alg.DiagonalSum(mat);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] mat = [[5]];
            int exp = 5;
            int res = alg.DiagonalSum(mat);
            Assert.AreEqual(exp, res);
        }
    }
}
