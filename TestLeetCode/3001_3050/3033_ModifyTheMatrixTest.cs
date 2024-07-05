using leetCode._3001_3050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3001_3050
{
    [TestClass]
    public class _3033_ModifyTheMatrixTest
    {
        _3033_ModifyTheMatrixAlg alg = new _3033_ModifyTheMatrixAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] matrix = [[1, 2, -1], [4, -1, 6], [7, 8, 9]];
            int[][] exp = [[1, 2, 9], [4, 8, 6], [7, 8, 9]];
            int[][] res = alg.ModifiedMatrix(matrix);
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] matrix = [[1, 2, -1], [4, -1, 6], [7, 8, 9]];
            int[][] exp = [[1, 2, 9], [4, 8, 6], [7, 8, 9]];
            int[][] res = alg.ModifiedMatrix(matrix);
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);
        }
    }
}
