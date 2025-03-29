using leetCode._2351_2400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2351_2400
{
    [TestClass]
    public class _2360_LongestCycleInAGraphTest
    {
        _2360_LongestCycleInAGraphAlg alg = new _2360_LongestCycleInAGraphAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] edges = [3, 3, 4, 2, 3];
            int exp = 3;
            int res = alg.LongestCycle(edges);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] edges = [2, -1, 3, 1];
            int exp = -1;
            int res = alg.LongestCycle(edges);
            Assert.AreEqual(exp, res);
        }
    }
}
