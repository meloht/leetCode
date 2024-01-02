using leetCode._0501_0550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0501_0550
{
    [TestClass]
    public class _509_FibonacciNumberUnitTest
    {
        _509_FibonacciNumberAlg alg = new _509_FibonacciNumberAlg();


        [TestMethod]
        public void TestCase01()
        {
            int n = 2;
            int res = alg.Fib(n);

            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 3;
            int res = alg.Fib(n);

            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 4;
            int res = alg.Fib(n);

            Assert.AreEqual(3, res);
        }
    }
}
