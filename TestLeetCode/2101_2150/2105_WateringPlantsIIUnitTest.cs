using leetCode._2101_2150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2101_2150
{
    [TestClass]
    public class _2105_WateringPlantsIIUnitTest
    {
        _2105_WateringPlantsIIAlg alg = new _2105_WateringPlantsIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] plants = [2, 2, 3, 3];
            int capacityA = 5;
            int capacityB = 5;
            int exp = 1;
            int res = alg.MinimumRefill(plants, capacityA, capacityB);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] plants = [2, 2, 3, 3];
            int capacityA = 3;
            int capacityB = 4;
            int exp = 2;
            int res = alg.MinimumRefill(plants, capacityA, capacityB);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] plants = [5];
            int capacityA = 10;
            int capacityB = 8;
            int exp = 0;
            int res = alg.MinimumRefill(plants, capacityA, capacityB);
            Assert.AreEqual(exp, res);
        }

    }
}
