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
    }
}
