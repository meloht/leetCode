using leetCode._0601_0650;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0601_0650
{
    [TestClass]
    public class _621_TaskSchedulerTest
    {
        _621_TaskSchedulerAlg alg = new _621_TaskSchedulerAlg();

        [TestMethod]
        public void TestCase01()
        {
            char[] tasks = ['A', 'A', 'A', 'B', 'B', 'B'];
            int n = 2;
            int exp = 8;
            int res = alg.LeastInterval(tasks,n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            char[] tasks = ['A', 'C', 'A', 'B', 'D', 'B'];
            int n = 1;
            int exp = 6;
            int res = alg.LeastInterval(tasks, n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            char[] tasks = ['A', 'A', 'A', 'B', 'B', 'B'];
            int n = 3;
            int exp = 10;
            int res = alg.LeastInterval(tasks, n);
            Assert.AreEqual(exp, res);
        }
    }
}
