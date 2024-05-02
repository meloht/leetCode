using leetCode._0851_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0851_0900
{
    [TestClass]
    public class _857_MinimumCostToHireKWorkersUnitTest
    {
        _857_MinimumCostToHireKWorkersAlg alg = new _857_MinimumCostToHireKWorkersAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] quality = [10, 20, 5], wage = [70, 50, 30];
            int k = 2;
            double exp = 105.00000;
            double res = alg.MincostToHireWorkers(quality, wage, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] quality = [3, 1, 10, 10, 1], wage = [4, 8, 2, 2, 7];
            int k = 3;
            double exp = 30.66667;
            double res = alg.MincostToHireWorkers(quality, wage, k);
            Assert.AreEqual(exp, res);
        }
    }
}
