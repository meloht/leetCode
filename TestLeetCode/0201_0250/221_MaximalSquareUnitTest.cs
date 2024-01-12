using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0201_0250
{
    [TestClass]
    public class _221_MaximalSquareUnitTest
    {
        _221_MaximalSquareAlg alg = new _221_MaximalSquareAlg();

        [TestMethod]
        public void TestCase01()
        {
            char[][] matrix = [['1', '0', '1', '0', '0'], ['1', '0', '1', '1', '1'], ['1', '1', '1', '1', '1'], ['1', '0', '0', '1', '0']];
            int exp = 4;
            int res = alg.MaximalSquare(matrix);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            char[][] matrix = [['0', '1'], ['1', '0']];
            int exp = 1;
            int res = alg.MaximalSquare(matrix);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            char[][] matrix = [['0']];
            int exp = 0;
            int res = alg.MaximalSquare(matrix);
            Assert.AreEqual(exp, res);
        }
    }
}
