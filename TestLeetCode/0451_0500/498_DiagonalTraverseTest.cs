using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _498_DiagonalTraverseTest
    {
        _498_DiagonalTraverseAlg alg = new _498_DiagonalTraverseAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] mat = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
            int[] exp = [1, 2, 4, 7, 5, 3, 6, 8, 9];
            int[] res = alg.FindDiagonalOrder(mat);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] mat = [[1, 2], [3, 4]];
            int[] exp = [1, 2, 3, 4];
            int[] res = alg.FindDiagonalOrder(mat);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
