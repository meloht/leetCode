using leetCode._0851_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0851_0900
{
    [TestClass]
    public class _886_PossibleBipartitionUnitTest
    {
        _886_PossibleBipartitionAlg alg = new _886_PossibleBipartitionAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 4;
            int[][] dislikes = [[1, 2], [1, 3], [2, 4]];
            bool exp = true;
            bool res = alg.PossibleBipartition(n, dislikes);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 3;
            int[][] dislikes = [[1, 2], [1, 3], [2, 3]];
            bool exp = false;
            bool res = alg.PossibleBipartition(n, dislikes);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 5;
            int[][] dislikes = [[1, 2], [2, 3], [3, 4], [4, 5], [1, 5]];
            bool exp = false;
            bool res = alg.PossibleBipartition(n, dislikes);
            Assert.AreEqual(exp, res);
        }
    }
}
