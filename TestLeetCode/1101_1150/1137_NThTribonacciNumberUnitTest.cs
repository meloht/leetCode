using leetCode._1101_1150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1101_1150
{
    [TestClass]
    public class _1137_NThTribonacciNumberUnitTest
    {
        _1137_NThTribonacciNumberAlg alg = new _1137_NThTribonacciNumberAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 4;
            int res = alg.Tribonacci(n);
            Assert.AreEqual(4, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 25;
            int res = alg.Tribonacci(n);
            Assert.AreEqual(1389537, res);
        }
    }
}
