using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._51_100
{
    [TestClass]
    public class _74_SearchA2dMatrixUnitTest
    {
        _74_SearchA2dMatrixAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _74_SearchA2dMatrixAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            var matrix = new int[][] { [1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60] };
            bool bl = alg.SearchMatrix(matrix, 3);
            Assert.AreEqual(bl, true);
        }

        [TestMethod]
        public void TestCase02()
        {
            var matrix = new int[][] { [1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60] };
            bool bl = alg.SearchMatrix(matrix, 13);
            Assert.AreEqual(bl, false);
        }

        [TestMethod]
        public void TestCase03()
        {
            var matrix = new int[][] { [1] };
            bool bl = alg.SearchMatrix(matrix, 0);
            Assert.AreEqual(bl, false);
        }
        [TestMethod]
        public void TestCase04()
        {
            var matrix = new int[][] { [1] };
            bool bl = alg.SearchMatrix(matrix, 1);
            Assert.AreEqual(bl, true);
        }

        [TestMethod]
        public void TestCase05()
        {
            var matrix = new int[][] { [1], [3] };
            bool bl = alg.SearchMatrix(matrix, 2);
            Assert.AreEqual(bl, false);
        }

        [TestMethod]
        public void TestCase06()
        {
            var matrix = new int[][] { [1], [3] };
            bool bl = alg.SearchMatrix(matrix, 3);
            Assert.AreEqual(bl, true);
        }
        [TestMethod]
        public void TestCase07()
        {
            var matrix = new int[][] { [1], [3], [5] };
            bool bl = alg.SearchMatrix(matrix, 4);
            Assert.AreEqual(bl, false);
        }

        [TestMethod]
        public void TestCase08()
        {
            var matrix = new int[][] { [1], [3], [5] };
            bool bl = alg.SearchMatrix(matrix, 5);
            Assert.AreEqual(bl, true);
        }

        [TestMethod]
        public void TestCase09()
        {
            var matrix = new int[][] { [1], [3], [5] };
            bool bl = alg.SearchMatrix(matrix, 6);
            Assert.AreEqual(bl, false);
        }

        [TestMethod]
        public void TestCase10()
        {
            var matrix = new int[][] { [-9, -7, -7, -5, -3], [-1, 0, 1, 3, 3], [5, 7, 9, 11, 12], [13, 14, 15, 16, 18], [19, 21, 22, 22, 22] };
            bool bl = alg.SearchMatrix(matrix, -4);
            Assert.AreEqual(bl, false);
        }
    }
}
