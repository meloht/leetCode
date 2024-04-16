using leetCode._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0751_0800
{
    [TestClass]
    public class _766_ToeplitzMatrixUnitTest
    {
        _766_ToeplitzMatrixAlg alg = new _766_ToeplitzMatrixAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] matrix = [[1, 2, 3, 4], [5, 1, 2, 3], [9, 5, 1, 2]];
            bool exp = true;
            bool res = alg.IsToeplitzMatrix(matrix);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] matrix = [[1, 2], [2, 2]];
            bool exp = false;
            bool res = alg.IsToeplitzMatrix(matrix);
            Assert.AreEqual(exp, res);
        }
    }
}
