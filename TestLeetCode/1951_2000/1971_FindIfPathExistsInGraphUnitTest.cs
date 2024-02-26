using leetCode._1951_2000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1951_2000
{
    [TestClass]
    public class _1971_FindIfPathExistsInGraphUnitTest
    {
        _1971_FindIfPathExistsInGraphAlg alg = new _1971_FindIfPathExistsInGraphAlg();


        [TestMethod]
        public void TestCase01()
        {
            int n = 3;
            int[][] edges = [[0, 1], [1, 2], [2, 0]];
            int source = 0, destination = 2;
            bool exp = true;
            bool res = alg.ValidPath(n, edges, source, destination);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 6;
            int[][] edges = [[0, 1], [0, 2], [3, 5], [5, 4], [4, 3]];
            int source = 0, destination = 5;
            bool exp = false;
            bool res = alg.ValidPath(n, edges, source, destination);
            Assert.AreEqual(exp, res);
        }
    }
}
