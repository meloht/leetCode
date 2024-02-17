using leetCode._1301_1350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1301_1350
{
    [TestClass]
    public class _1319_NumberOfOperationsToMakeNetworkConnectedUnitTest
    {
        _1319_NumberOfOperationsToMakeNetworkConnectedAlg alg = new _1319_NumberOfOperationsToMakeNetworkConnectedAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 4;
            int[][] connections = [[0, 1], [0, 2], [1, 2]];
            int exp = 1;
            int res = alg.MakeConnected(n, connections);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 6;
            int[][] connections = [[0, 1], [0, 2], [0, 3], [1, 2], [1, 3]];
            int exp = 2;
            int res = alg.MakeConnected(n, connections);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 6;
            int[][] connections = [[0, 1], [0, 2], [0, 3], [1, 2]];
            int exp = -1;
            int res = alg.MakeConnected(n, connections);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int n = 5;
            int[][] connections = [[0, 1], [0, 2], [3, 4], [2, 3]];
            int exp = 0;
            int res = alg.MakeConnected(n, connections);
            Assert.AreEqual(exp, res);
        }
    }
}
