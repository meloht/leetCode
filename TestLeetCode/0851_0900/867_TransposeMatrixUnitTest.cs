using leetCode._0851_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0851_0900
{
    [TestClass]
    public class _867_TransposeMatrixUnitTest
    {
        _867_TransposeMatrixAlg alg = new _867_TransposeMatrixAlg();
        
        [TestMethod]
        public void TestCase01()
        {
            int[][] matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
            int[][] exp = [[1, 4, 7], [2, 5, 8], [3, 6, 9]];
            int[][] res = alg.Transpose(matrix);
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);

        }
        [TestMethod]
        public void TestCase02()
        {
            int[][] matrix = [[1, 2, 3], [4, 5, 6]];
            int[][] exp = [[1, 4], [2, 5], [3, 6]];
            int[][] res = alg.Transpose(matrix);
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);

        }
    }
}
