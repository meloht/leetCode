using leetCode._1501_1550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1501_1550
{
    [TestClass]
    public class _1547_MinimumCostToCutAStickTest
    {
        _1547_MinimumCostToCutAStickAlg alg = new _1547_MinimumCostToCutAStickAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 7;
            int[] cuts = [1, 3, 4, 5];
            int exp = 16;
            int res = alg.MinCost(n, cuts);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 9;
            int[] cuts = [5, 6, 1, 4, 2];
            int exp = 22;
            int res = alg.MinCost(n, cuts);
            Assert.AreEqual(exp, res);
        }
    }
}
