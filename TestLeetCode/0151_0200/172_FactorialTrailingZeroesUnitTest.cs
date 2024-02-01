using leetCode._0151_0200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0151_0200
{
    [TestClass]
    public class _172_FactorialTrailingZeroesUnitTest
    {
        _172_FactorialTrailingZeroesAlg alg = new _172_FactorialTrailingZeroesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 3;
            var res = alg.TrailingZeroes(n);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 5;
            var res = alg.TrailingZeroes(n);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 0;
            var res = alg.TrailingZeroes(n);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int n = 30;
            var res = alg.TrailingZeroes(n);
            Assert.AreEqual(7, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int n = 625;
            var res = alg.TrailingZeroes(n);
            Assert.AreEqual(156, res);
        }
    }
}
