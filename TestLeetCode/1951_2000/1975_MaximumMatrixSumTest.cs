using leetCode._1951_2000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1951_2000
{
    [TestClass]
    public class _1975_MaximumMatrixSumTest
    {
        _1975_MaximumMatrixSumAlg alg = new _1975_MaximumMatrixSumAlg();

        [TestMethod]
        public void Test01()
        {
            int[][] matrix = [[1, -1], [-1, 1]];
            long exp = 4;
            long res = alg.MaxMatrixSum(matrix);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test02()
        {
            int[][] matrix = [[1, 2, 3], [-1, -2, -3], [1, 2, 3]];
            long exp = 16;
            long res = alg.MaxMatrixSum(matrix);
            Assert.AreEqual(exp, res);
        }
    }
}
