using leetCode._1151_1200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1151_1200
{
    [TestClass]
    public class _1190_ReverseSubstringsBetweenEachPairOfParenthesesTest
    {
        _1190_ReverseSubstringsBetweenEachPairOfParenthesesAlg alg = new _1190_ReverseSubstringsBetweenEachPairOfParenthesesAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "(abcd)";
            string exp = "dcba";
            string res = alg.ReverseParentheses(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "(u(love)i)";
            string exp = "iloveu";
            string res = alg.ReverseParentheses(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "(ed(et(oc))el)";
            string exp = "leetcode";
            string res = alg.ReverseParentheses(s);
            Assert.AreEqual(exp, res);
        }
    }
}
