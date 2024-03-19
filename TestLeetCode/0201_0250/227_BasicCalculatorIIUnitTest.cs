using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0201_0250
{
    [TestClass]
    public class _227_BasicCalculatorIIUnitTest
    {
        _227_BasicCalculatorIIAlg alg = new _227_BasicCalculatorIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "3+2*2";
            int exp = 7;
            int res = alg.Calculate(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = " 3/2 ";
            int exp = 1;
            int res = alg.Calculate(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = " 3+5 / 2 ";
            int exp = 5;
            int res = alg.Calculate(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string s = "2*3*4";
            int exp = 24;
            int res = alg.Calculate(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            string s = "1-1+1";
            int exp = 1;
            int res = alg.Calculate(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase06()
        {
            string s = " 3+4/-2 ";
            int exp = 1;
            int res = alg.Calculate(s);
            Assert.AreEqual(exp, res);
        }

    }
}
