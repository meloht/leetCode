using leetCode._2051_2100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2051_2100
{
    [TestClass]
    public class _2079_WateringPlantsUnitTest
    {
        _2079_WateringPlantsAlg alg = new _2079_WateringPlantsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] plants = [2, 2, 3, 3];
            int capacity = 5;
            int exp = 14;
            int res = alg.WateringPlants(plants, capacity);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] plants = [1, 1, 1, 4, 2, 3];
            int capacity = 4;
            int exp = 30;
            int res = alg.WateringPlants(plants, capacity);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] plants = [7, 7, 7, 7, 7, 7, 7];
            int capacity = 8;
            int exp = 49;
            int res = alg.WateringPlants(plants, capacity);
            Assert.AreEqual(exp, res);
        }
    }
}
