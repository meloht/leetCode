using leetCode._0501_0550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0501_0550
{
    [TestClass]
    public class _542_01MatrixTest
    {
        _542_01MatrixAlg alg = new _542_01MatrixAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] mat = [[0, 0, 0], [0, 1, 0], [0, 0, 0]];
            int[][] exp = [[0, 0, 0], [0, 1, 0], [0, 0, 0]];
            int[][] res = alg.UpdateMatrix(mat);
            Assert.IsTrue(Utils.IsSameArr(exp, res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] mat = [[0, 0, 0], [0, 1, 0], [1, 1, 1]];
            int[][] exp = [[0, 0, 0], [0, 1, 0], [1, 2, 1]];
            int[][] res = alg.UpdateMatrix(mat);
            Assert.IsTrue(Utils.IsSameArr(exp, res));
        }
    }
}
