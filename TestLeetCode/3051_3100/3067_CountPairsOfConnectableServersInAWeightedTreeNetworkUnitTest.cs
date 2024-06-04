using leetCode._3051_3100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3051_3100
{
    [TestClass]
    public class _3067_CountPairsOfConnectableServersInAWeightedTreeNetworkUnitTest
    {
        _3067_CountPairsOfConnectableServersInAWeightedTreeNetworkAlg alg = new _3067_CountPairsOfConnectableServersInAWeightedTreeNetworkAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] edges = [[0, 1, 1], [1, 2, 5], [2, 3, 13], [3, 4, 9], [4, 5, 2]];
            int signalSpeed = 1;
            int[] exp = [0, 4, 6, 6, 4, 0];
            int[] res = alg.CountPairsOfConnectableServers(edges, signalSpeed);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] edges = [[0, 6, 3], [6, 5, 3], [0, 3, 1], [3, 2, 7], [3, 1, 6], [3, 4, 2]];
            int signalSpeed = 3;
            int[] exp = [2, 0, 0, 0, 0, 0, 2];
            int[] res = alg.CountPairsOfConnectableServers(edges, signalSpeed);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
