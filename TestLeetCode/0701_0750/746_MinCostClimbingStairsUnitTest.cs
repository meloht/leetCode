using leetCode._0701_0750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0701_0750
{
    [TestClass]
    public class _746_MinCostClimbingStairsUnitTest
    {
        _746_MinCostClimbingStairsAlg alg = new _746_MinCostClimbingStairsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] cost = [10, 15, 20];
            int exp = 15;
            int res = alg.MinCostClimbingStairs(cost);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] cost = [1, 100, 1, 1, 1, 100, 1, 1, 100, 1];
            int exp = 6;
            int res = alg.MinCostClimbingStairs(cost);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] cost = [0, 0, 1, 1];
            int exp = 1;
            int res = alg.MinCostClimbingStairs(cost);
            Assert.AreEqual(exp, res);
        }
    }
}
