using leetCode._0601_0650;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0601_0650
{
    [TestClass]
    public class _605_CanPlaceFlowersUnitTest
    {
        _605_CanPlaceFlowersAlg alg = new _605_CanPlaceFlowersAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] flowerbed = [1, 0, 0, 0, 1];
            int n = 1;
            bool exp = true;
            bool res = alg.CanPlaceFlowers(flowerbed, n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] flowerbed = [1, 0, 0, 0, 1];
            int n = 2;
            bool exp = false;
            bool res = alg.CanPlaceFlowers(flowerbed, n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] flowerbed = [1, 0, 0, 0, 0];
            int n = 2;
            bool exp = true;
            bool res = alg.CanPlaceFlowers(flowerbed, n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] flowerbed = [1, 0, 0, 0, 0, 1];
            int n = 2;
            bool exp = false;
            bool res = alg.CanPlaceFlowers(flowerbed, n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[] flowerbed = [0, 0, 1, 0, 1];
            int n = 1;
            bool exp = true;
            bool res = alg.CanPlaceFlowers(flowerbed, n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase06()
        {
            int[] flowerbed = [0, 0, 0];
            int n = 2;
            bool exp = true;
            bool res = alg.CanPlaceFlowers(flowerbed, n);
            Assert.AreEqual(exp, res);
        }
    }
}
