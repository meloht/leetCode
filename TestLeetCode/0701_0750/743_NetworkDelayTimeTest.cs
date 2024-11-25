using leetCode._0701_0750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0701_0750
{
    [TestClass]
    public class _743_NetworkDelayTimeTest
    {
        _743_NetworkDelayTimeAlg alg = new _743_NetworkDelayTimeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] times = [[2, 1, 1], [2, 3, 1], [3, 4, 1]];
            int n = 4, k = 2;
            int exp = 2;
            int res = alg.NetworkDelayTime(times, n, k);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            int[][] times = [[1, 2, 1]];
            int n = 2, k = 1;
            int exp = 1;
            int res = alg.NetworkDelayTime(times, n, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] times = [[1, 2, 1]];
            int n = 2, k = 1;
            int exp = 1;
            int res = alg.NetworkDelayTime(times, n, k);
            Assert.AreEqual(exp, res);
        }
    }
}
