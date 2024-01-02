using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0201_0250
{
    [TestClass]
    public class _204_CountPrimesUnitTest
    {
        _204_CountPrimesAlg alg = new _204_CountPrimesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 10;
            int res = alg.CountPrimes(n);
            Assert.AreEqual(4, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 0;
            int res = alg.CountPrimes(n);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 1;
            int res = alg.CountPrimes(n);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int n = 461465;
            int res = alg.CountPrimes(n);
            Assert.AreEqual(38571, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int n = 2;
            int res = alg.CountPrimes(n);
            Assert.AreEqual(0, res);
        }
    }
}
