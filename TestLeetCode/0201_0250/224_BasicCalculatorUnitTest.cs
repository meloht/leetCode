using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0201_0250
{
    [TestClass]
    public class _224_BasicCalculatorUnitTest
    {
        _224_BasicCalculatorAlg alg = new _224_BasicCalculatorAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "1 + 1";
            int exp = 2;
            int res = alg.Calculate(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = " 2-1 + 2 ";
            int exp = 3;
            int res = alg.Calculate(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "(1+(4+5+2)-3)+(6+8)";
            int exp = 23;
            int res = alg.Calculate(s);
            Assert.AreEqual(exp, res);
        }
    }
}
