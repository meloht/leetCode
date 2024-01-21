using leetCode._2801_2850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._2801_2850
{
    [TestClass]
    public class _2827_NumberOfBeautifulIntegersInTheRangeUnitTest
    {
        _2827_NumberOfBeautifulIntegersInTheRangeAlg alg = new _2827_NumberOfBeautifulIntegersInTheRangeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int low = 10, high = 20, k = 3;
            int exp = 2;
            int res = alg.NumberOfBeautifulIntegers(low, high, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int low = 1, high = 10, k = 1;
            int exp = 1;
            int res = alg.NumberOfBeautifulIntegers(low, high, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int low = 5, high = 5, k = 2;
            int exp = 0;
            int res = alg.NumberOfBeautifulIntegers(low, high, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int low = 100, high = 20000000, k = 3;
            int exp = 1006358;
            int res = alg.NumberOfBeautifulIntegers(low, high, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int low = 26, high = 74, k = 7;
            int exp = 4;
            int res = alg.NumberOfBeautifulIntegers(low, high, k);
            Assert.AreEqual(exp, res);
        }
    }
}
