using leetCode._1251_1300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1251_1300
{
    [TestClass]
    public class _1267_CountServersThatCommunicateUnitTest
    {
        _1267_CountServersThatCommunicateAlg alg = new _1267_CountServersThatCommunicateAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] grid = [[1, 0], [0, 1]];
            int exp = 0;
            int res = alg.CountServers(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] grid = [[1, 0], [1, 1]];
            int exp = 3;
            int res = alg.CountServers(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] grid = [[1, 1, 0, 0], [0, 0, 1, 0], [0, 0, 1, 0], [0, 0, 0, 1]];
            int exp = 4;
            int res = alg.CountServers(grid);
            Assert.AreEqual(exp, res);
        }
    }
}
