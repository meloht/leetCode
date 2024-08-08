using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _475_HeatersTest
    {
        _475_HeatersAlg alg = new _475_HeatersAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] houses = [1, 2, 3], heaters = [2];
            int exp = 1;
            int res = alg.FindRadius(houses, heaters);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] houses = [1, 2, 3, 4], heaters = [1, 4];
            int exp = 1;
            int res = alg.FindRadius(houses, heaters);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] houses = [1, 5], heaters = [2];
            int exp = 3;
            int res = alg.FindRadius(houses, heaters);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] houses = [1, 2, 3], heaters = [1, 2, 3];
            int exp = 0;
            int res = alg.FindRadius(houses, heaters);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[] houses = [1, 2, 3, 5, 15], heaters = [2, 30];
            int exp = 13;
            int res = alg.FindRadius(houses, heaters);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase06()
        {
            int[] houses = [1, 1, 1, 1, 1, 1, 999, 999, 999, 999, 999], heaters = [499, 500, 501];
            int exp = 498;
            int res = alg.FindRadius(houses, heaters);
            Assert.AreEqual(exp, res);
        }
    }
}
