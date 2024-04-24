using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1001_1050
{
    [TestClass]
    public class _1021_RemoveOutermostParenthesesUnitTest
    {
        _1021_RemoveOutermostParenthesesAlg alg = new _1021_RemoveOutermostParenthesesAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "(()())(())";
            string exp = "()()()";
            string res = alg.RemoveOuterParentheses(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "(()())(())(()(()))";
            string exp = "()()()()(())";
            string res = alg.RemoveOuterParentheses(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "()()";
            string exp = "";
            string res = alg.RemoveOuterParentheses(s);
            Assert.AreEqual(exp, res);
        }
    }
}
