using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0301_0350
{
    [TestClass]
    public class _301_RemoveInvalidParenThesesUnitTest
    {
        _301_RemoveInvalidParenThesesAlg alg = new _301_RemoveInvalidParenThesesAlg();
        [TestMethod]
        public void TestCase01()
        {
            string s = "()())()";
            string[] exp = ["(())()", "()()()"];
            string[] res = alg.RemoveInvalidParentheses(s).ToArray();
            Assert.IsTrue(Utils.IsSameArr(exp,res));
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "(a)())()";
            string[] exp = ["(a())()", "(a)()()"];
            string[] res = alg.RemoveInvalidParentheses(s).ToArray();
            Assert.IsTrue(Utils.IsSameArr(exp, res));
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = ")(";
            string[] exp = [""];
            string[] res = alg.RemoveInvalidParentheses(s).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase04()
        {
            string s = ")(f";
            string[] exp = ["f"];
            string[] res = alg.RemoveInvalidParentheses(s).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
