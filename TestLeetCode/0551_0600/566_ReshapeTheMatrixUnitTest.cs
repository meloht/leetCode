using leetCode._0551_0600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0551_0600
{
    [TestClass]
    public class _566_ReshapeTheMatrixUnitTest
    {
        _566_ReshapeTheMatrixAlg alg = new _566_ReshapeTheMatrixAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] mat = [[1, 2], [3, 4]];
            int r = 1, c = 4;
            int[][] exp = [[1, 2, 3, 4]];
            int[][] res = alg.MatrixReshape(mat, r, c);
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] mat = [[1, 2], [3, 4]];
            int r = 2, c = 4;
            int[][] exp = [[1, 2], [3, 4]];
            int[][] res = alg.MatrixReshape(mat, r, c);
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);
        }
    }
}
