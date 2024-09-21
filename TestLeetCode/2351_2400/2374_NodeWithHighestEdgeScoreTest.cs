using leetCode._2351_2400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2351_2400
{
    [TestClass]
    public class _2374_NodeWithHighestEdgeScoreTest
    {
        _2374_NodeWithHighestEdgeScoreAlg alg = new _2374_NodeWithHighestEdgeScoreAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] edges = [1, 0, 0, 0, 0, 7, 7, 5];
            int exp = 7;
            int res = alg.EdgeScore(edges);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase02()
        {
            int[] edges = [2, 0, 0, 2];
            int exp = 0;
            int res = alg.EdgeScore(edges);
            Assert.AreEqual(exp, res);

        }
    }
}
