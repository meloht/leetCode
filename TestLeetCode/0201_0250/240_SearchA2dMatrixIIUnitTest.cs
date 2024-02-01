using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0201_0250
{
    [TestClass]
    public class _240_SearchA2dMatrixIIUnitTest
    {
        _240_SearchA2dMatrixIIAlg alg = new _240_SearchA2dMatrixIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] matrix = [[1, 4, 7, 11, 15], [2, 5, 8, 12, 19], [3, 6, 9, 16, 22], [10, 13, 14, 17, 24], [18, 21, 23, 26, 30]];
            bool bl = alg.SearchMatrix(matrix, 5);
            Assert.AreEqual(bl, true);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] matrix = [[1, 4, 7, 11, 15], [2, 5, 8, 12, 19], [3, 6, 9, 16, 22], [10, 13, 14, 17, 24], [18, 21, 23, 26, 30]];
            bool bl = alg.SearchMatrix(matrix, 20);
            Assert.AreEqual(bl, false);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[][] matrix = [[-5]];
            bool bl = alg.SearchMatrix(matrix, -10);
            Assert.AreEqual(bl, false);
        }

        [TestMethod]
        public void TestCase06()
        {
            int[][] matrix = [[1, 1]];
            bool bl = alg.SearchMatrix(matrix, 2);
            Assert.AreEqual(bl, false);
        }

        [TestMethod]
        public void TestCase07()
        {
            int[][] matrix = [[1, 1]];
            bool bl = alg.SearchMatrix(matrix, 0);
            Assert.AreEqual(bl, false);
        }

        [TestMethod]
        public void TestCase08()
        {
            int[][] matrix = [[1, 3, 5, 7, 9], [2, 4, 6, 8, 10], [11, 13, 15, 17, 19], [12, 14, 16, 18, 20], [21, 22, 23, 24, 25]];
            bool bl = alg.SearchMatrix(matrix, 13);
            Assert.AreEqual(bl, true);
        }
    }
}
