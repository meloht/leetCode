using leetCode._2101_2150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2101_2150
{
    [TestClass]
    public class _2116_CheckIfAParenthesesStringCanBeValidTest
    {
        _2116_CheckIfAParenthesesStringCanBeValidAlg alg = new _2116_CheckIfAParenthesesStringCanBeValidAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "))()))", locked = "010100";
            bool exp = true;
            bool res = alg.CanBeValid(s, locked);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "()()", locked = "0000";
            bool exp = true;
            bool res = alg.CanBeValid(s, locked);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = ")", locked = "0";
            bool exp = false;
            bool res = alg.CanBeValid(s, locked);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string s = "(((())(((())", locked = "111111010111";
            bool exp = true;
            bool res = alg.CanBeValid(s, locked);
            Assert.AreEqual(exp, res);
        }
    }
}
