using leetCode._0651_0700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0651_0700
{
    [TestClass]
    public class _699_FallingSquaresTest
    {
        _699_FallingSquaresAlg alg = new _699_FallingSquaresAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] positions = [[1, 2], [2, 3], [6, 1]];
            int[] exp = [2, 5, 5];
            int[] res = alg.FallingSquares(positions).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] positions = [[100, 100], [200, 100]];
            int[] exp = [100, 100];
            int[] res = alg.FallingSquares(positions).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
