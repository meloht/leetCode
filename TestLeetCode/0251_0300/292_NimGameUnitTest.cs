using leetCode._0251_0300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0251_0300
{
    [TestClass]
    public class _292_NimGameUnitTest
    {
        _292_NimGameAlg alg = new _292_NimGameAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 4;
            bool exp = false;
            bool res = alg.CanWinNim(n);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase02()
        {
            int n = 1;
            bool exp = true;
            bool res = alg.CanWinNim(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 2;
            bool exp = true;
            bool res = alg.CanWinNim(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int n = 5;
            bool exp = true;
            bool res = alg.CanWinNim(n);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase05()
        {
            int n = 6;
            bool exp = true;
            bool res = alg.CanWinNim(n);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase06()
        {
            int n = 7;
            bool exp = true;
            bool res = alg.CanWinNim(n);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase08()
        {
            int n = 8;
            bool exp = false;
            bool res = alg.CanWinNim(n);
            Assert.AreEqual(exp, res);
        }
    }
}
