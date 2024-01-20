using leetCode._0551_0600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0551_0600
{
    [TestClass]
    public class _600_NonNegativeIntegersWithoutConsecutiveOnesUnitTest
    {
        _600_NonNegativeIntegersWithoutConsecutiveOnesAlg alg = new _600_NonNegativeIntegersWithoutConsecutiveOnesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 5;
            int exp = 5;
            int res = alg.FindIntegers(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 1;
            int exp = 2;
            int res = alg.FindIntegers(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 2;
            int exp = 3;
            int res = alg.FindIntegers(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int n = 100000000;
            int exp = 514229;
            int res = alg.FindIntegers(n);
            Assert.AreEqual(exp, res);
        }
    }
}
