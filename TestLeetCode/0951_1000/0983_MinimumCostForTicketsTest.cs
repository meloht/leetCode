using leetCode._0951_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0951_1000
{
    [TestClass]
    public class _0983_MinimumCostForTicketsTest
    {
        _0983_MinimumCostForTicketsAlg alg = new _0983_MinimumCostForTicketsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] days = [1, 4, 6, 7, 8, 20], costs = [2, 7, 15];
            int exp = 11;
            int res = alg.MincostTickets(days, costs);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] days = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 30, 31], costs = [2, 7, 15];
            int exp = 17;
            int res = alg.MincostTickets(days, costs);
            Assert.AreEqual(exp, res);
        }
    }
}
