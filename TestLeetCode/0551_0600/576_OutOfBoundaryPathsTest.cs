using leetCode._0551_0600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0551_0600
{
    [TestClass]
    public class _576_OutOfBoundaryPathsTest
    {
        _576_OutOfBoundaryPathsAlg alg = new _576_OutOfBoundaryPathsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int m = 2, n = 2, maxMove = 2, startRow = 0, startColumn = 0;
            int exp = 6;
            int res = alg.FindPaths(m, n, maxMove, startRow, startColumn);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int m = 1, n = 3, maxMove = 3, startRow = 0, startColumn = 1;
            int exp = 12;
            int res = alg.FindPaths(m, n, maxMove, startRow, startColumn);
            Assert.AreEqual(exp, res);
        }
    }
}
