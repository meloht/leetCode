using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._51_100
{
    [TestClass]
    public class _65_ValidNumberUnitTest
    {
        _65_ValidNumberAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _65_ValidNumberAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            var res = alg.IsNumber("0");
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            var res = alg.IsNumber("e");
            Assert.AreEqual(false, res);
        }
        [TestMethod]
        public void TestCase03()
        {
            var res = alg.IsNumber(".");
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            var res = alg.IsNumber("0089");
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void TestCase05()
        {
            var res = alg.IsNumber("2");
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void TestCase06()
        {
            var res = alg.IsNumber("-0.1");
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void TestCase07()
        {
            var res = alg.IsNumber("+3.14");
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void TestCase08()
        {
            var res = alg.IsNumber("4.");
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void TestCase09()
        {
            var res = alg.IsNumber("-.9");
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void TestCase10()
        {
            var res = alg.IsNumber("2e10");
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void TestCase11()
        {
            var res = alg.IsNumber("-90E3");
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void TestCase12()
        {
            var res = alg.IsNumber("3e+7");
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void TestCase13()
        {
            var res = alg.IsNumber("+6e-1");
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void TestCase14()
        {
            var res = alg.IsNumber("53.5e93");
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void TestCase15()
        {
            var res = alg.IsNumber("-123.456e789");
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestCase16()
        {
            var res = alg.IsNumber("abc");
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void TestCase17()
        {
            var res = alg.IsNumber("1a");
            Assert.AreEqual(false, res);
        }
        [TestMethod]
        public void TestCase18()
        {
            var res = alg.IsNumber("1e");
            Assert.AreEqual(false, res);
        }
        [TestMethod]
        public void TestCase19()
        {
            var res = alg.IsNumber("e3");
            Assert.AreEqual(false, res);
        }
        [TestMethod]
        public void TestCase20()
        {
            var res = alg.IsNumber("99e2.5");
            Assert.AreEqual(false, res);
        }
        [TestMethod]
        public void TestCase21()
        {
            var res = alg.IsNumber("--6");
            Assert.AreEqual(false, res);
        }
        [TestMethod]
        public void TestCase22()
        {
            var res = alg.IsNumber("-+3");
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void TestCase23()
        {
            var res = alg.IsNumber("95a54e53");
            Assert.AreEqual(false, res);
        }
        [TestMethod]
        public void TestCase24()
        {
            var res = alg.IsNumber("+.");
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void TestCase25()
        {
            var res = alg.IsNumber("46.e3");
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void TestCase26()
        {
            var res = alg.IsNumber(".1");
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestCase27()
        {
            var res = alg.IsNumber("4e+");
            Assert.AreEqual(false, res);
        }
        [TestMethod]
        public void TestCase28()
        {
            var res = alg.IsNumber("1e.");
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void TestCase29()
        {
            var res = alg.IsNumber("+E3");
            Assert.AreEqual(false, res);
        }
    }
}
