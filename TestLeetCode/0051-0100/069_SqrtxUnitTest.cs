using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0051_0100
{
    [TestClass]
    public class _69_SqrtxUnitTest
    {
        _69_SqrtxAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _69_SqrtxAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            int res = alg.MySqrt(4);
            int exp = 2;
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int res = alg.MySqrt(8);
            int exp = 2;
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int res = alg.MySqrt(36);
            int exp = 6;
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int res = alg.MySqrt(2147395599);
            int exp = 46339;
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int res = alg.MySqrt(144);
            int exp = 12;
            Assert.AreEqual(exp, res);
        }
    }
}
