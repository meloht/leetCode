using leetCode._0601_0650;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0601_0650
{
    [TestClass]
    public class _650_2KeysKeyboardTest
    {
        _650_2KeysKeyboardAlg alg = new _650_2KeysKeyboardAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 3;
            int exp = 3;
            int res = alg.MinSteps(n);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            int n = 1;
            int exp = 0;
            int res = alg.MinSteps(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 111;
            int exp = 40;
            int res = alg.MinSteps(n);
            Assert.AreEqual(exp, res);
        }
    }
}
