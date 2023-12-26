using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0051_0100
{
    [TestClass]
    public class _73_SetMatrixZeroesUnitTest
    {
        _73_SetMatrixZeroesAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _73_SetMatrixZeroesAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            var matrix = new int[][] { [1, 1, 1], [1, 0, 1], [1, 1, 1] };
            var exp = new int[][] { [1, 0, 1], [0, 0, 0], [1, 0, 1] };
            alg.SetZeroes(matrix);
            bool bl= Utils.IsSameArr(exp, matrix);
            Assert.AreEqual(bl, true);
        }

        [TestMethod]
        public void TestCase02()
        {
            var matrix = new int[][] { [0, 1, 2, 0], [3, 4, 5, 2], [1, 3, 1, 5] };
            var exp = new int[][] { [0, 0, 0, 0], [0, 4, 5, 0], [0, 3, 1, 0] };
            alg.SetZeroes(matrix);
            bool bl = Utils.IsSameArr(exp, matrix);
            Assert.AreEqual(bl, true);
        }

     
    }
}
