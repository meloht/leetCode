using leetCode._0651_0700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0651_0700
{
    [TestClass]
    public class _678_ValidParenthesisStringTest
    {
        _678_ValidParenthesisStringAlg alg = new _678_ValidParenthesisStringAlg();
        [TestMethod]
        public void TestCase01()
        {
            string s = "()";
            bool exp = true;
            bool res = alg.CheckValidString(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "(*)";
            bool exp = true;
            bool res = alg.CheckValidString(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "(*))";
            bool exp = true;
            bool res = alg.CheckValidString(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string s = "(((()))())))*))())()(**(((())(()(*()((((())))*())(())*(*(()(*)))()*())**((()(()))())(*(*))*))())";
            bool exp = false;
            bool res = alg.CheckValidString(s);
            Assert.AreEqual(exp, res);
        }
    }
}
