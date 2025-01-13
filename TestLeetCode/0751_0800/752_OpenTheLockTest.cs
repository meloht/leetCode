using leetCode._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0751_0800
{
    [TestClass]
    public class _752_OpenTheLockTest
    {
        _752_OpenTheLockAlg alg = new _752_OpenTheLockAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] deadends = ["0201", "0101", "0102", "1212", "2002"];
            string target = "0202";
            int exp = 6;
            int res = alg.OpenLock(deadends, target);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] deadends = ["8888"];
            string target = "0009";
            int exp = 1;
            int res = alg.OpenLock(deadends, target);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string[] deadends = ["8887", "8889", "8878", "8898", "8788", "8988", "7888", "9888"];
            string target = "8888";
            int exp = -1;
            int res = alg.OpenLock(deadends, target);
            Assert.AreEqual(exp, res);
        }
    }
}
