using leetCode._0601_0650;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0601_0650
{
    [TestClass]
    public class _646_MaximumLengthOfPairChainTest
    {
        _646_MaximumLengthOfPairChainAlg alg = new _646_MaximumLengthOfPairChainAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] pairs = [[1, 2], [2, 3], [3, 4]];
            int exp = 2;
            int res = alg.FindLongestChain(pairs);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] pairs = [[1, 2], [7, 8], [4, 5]];
            int exp = 3;
            int res = alg.FindLongestChain(pairs);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] pairs = [[-10, -8], [8, 9], [-5, 0], [6, 10], [-6, -4], [1, 7], [9, 10], [-4, 7]];
            int exp = 4;
            int res = alg.FindLongestChain(pairs);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[][] pairs = [[-6, 9], [1, 6], [8, 10], [-1, 4], [-6, -2], [-9, 8], [-5, 3], [0, 3]];
            int exp = 3;
            int res = alg.FindLongestChain(pairs);
            Assert.AreEqual(exp, res);
        }
    }
}
