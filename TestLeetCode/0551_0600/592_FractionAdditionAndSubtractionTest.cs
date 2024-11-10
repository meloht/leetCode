using leetCode._0551_0600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0551_0600
{
    [TestClass]
    public class _592_FractionAdditionAndSubtractionTest
    {
        _592_FractionAdditionAndSubtractionAlg alg = new _592_FractionAdditionAndSubtractionAlg();

        [TestMethod]
        public void TestCase01()
        {
            string expression = "-1/2+1/2";
            string exp = "0/1";
            string res = alg.FractionAddition(expression);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string expression = "-1/2+1/2+1/3";
            string exp = "1/3";
            string res = alg.FractionAddition(expression);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string expression = "1/3-1/2";
            string exp = "-1/6";
            string res = alg.FractionAddition(expression);
            Assert.AreEqual(exp, res);
        }
    }
}
