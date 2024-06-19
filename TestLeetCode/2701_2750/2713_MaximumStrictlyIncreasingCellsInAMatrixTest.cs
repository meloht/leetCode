using leetCode._2701_2750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2701_2750
{
    [TestClass]
    public class _2713_MaximumStrictlyIncreasingCellsInAMatrixTest
    {
        _2713_MaximumStrictlyIncreasingCellsInAMatrixAlg alg = new _2713_MaximumStrictlyIncreasingCellsInAMatrixAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] mat = [[3, 1], [3, 4]];
            int exp = 2;
            int res = alg.MaxIncreasingCells(mat);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] mat = [[1, 1], [1, 1]];
            int exp = 1;
            int res = alg.MaxIncreasingCells(mat);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] mat = [[3, 1, 6], [-9, 5, 7]];
            int exp = 4;
            int res = alg.MaxIncreasingCells(mat);
            Assert.AreEqual(exp, res);
        }
    }
}
