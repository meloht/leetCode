using leetCode._2451_2500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2451_2500
{
    [TestClass]
    public class _2462_TotalCostToHireKWorkersUnitTest
    {
        _2462_TotalCostToHireKWorkersAlg alg = new _2462_TotalCostToHireKWorkersAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] costs = [17, 12, 10, 2, 7, 2, 11, 20, 8];
            int k = 3, candidates = 4;
            long exp = 11;
            long res = alg.TotalCost(costs, k, candidates);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] costs = [1, 2, 4, 1];
            int k = 3, candidates = 3;
            long exp = 4;
            long res = alg.TotalCost(costs, k, candidates);
            Assert.AreEqual(exp, res);
        }
    }
}
