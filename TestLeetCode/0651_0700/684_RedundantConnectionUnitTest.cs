using leetCode._0651_0700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0651_0700
{
    [TestClass]
    public class _684_RedundantConnectionUnitTest
    {
        _684_RedundantConnectionAlg alg = new _684_RedundantConnectionAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] edges = [[1, 2], [1, 3], [2, 3]];
            int[] exp = [2, 3];
            int[] res = alg.FindRedundantConnection(edges);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] edges = [[1, 2], [2, 3], [3, 4], [1, 4], [1, 5]];
            int[] exp = [1, 4];
            int[] res = alg.FindRedundantConnection(edges);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
