using leetCode._0351_0400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0351_0400
{
    [TestClass]
    public class _365_WaterAndJugProblemUnitTest
    {
        _365_WaterAndJugProblemAlg alg = new _365_WaterAndJugProblemAlg();

        [TestMethod]
        public void TestCase01()
        {
            int x = 3, y = 5, target = 4;
            bool exp = true;
            bool res = alg.CanMeasureWater(x, y, target);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int x = 2, y = 6, target = 5;
            bool exp = false;
            bool res = alg.CanMeasureWater(x, y, target);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase03()
        {
            int x = 1, y = 2, target = 3;
            bool exp = true;
            bool res = alg.CanMeasureWater(x, y, target);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase04()
        {
            int x = 34, y = 5, target = 6;
            bool exp = true;
            bool res = alg.CanMeasureWater(x, y, target);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int x = 1, y = 1, target = 12;
            bool exp = false;
            bool res = alg.CanMeasureWater(x, y, target);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase06()
        {
            int x = 13, y = 11, target = 1;
            bool exp = true;
            bool res = alg.CanMeasureWater(x, y, target);
            Assert.AreEqual(exp, res);
        }
    }
}
