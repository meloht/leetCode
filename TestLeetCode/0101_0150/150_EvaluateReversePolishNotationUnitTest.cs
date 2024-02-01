using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0101_0150
{
    [TestClass]
    public class _150_EvaluateReversePolishNotationUnitTest
    {
        _150_EvaluateReversePolishNotationAlg alg = new _150_EvaluateReversePolishNotationAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] tokens = ["2", "1", "+", "3", "*"];
            int res = alg.EvalRPN(tokens);
            Assert.AreEqual(9, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] tokens = ["4", "13", "5", "/", "+"];
            int res = alg.EvalRPN(tokens);
            Assert.AreEqual(6, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string[] tokens = ["10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+"];
            int res = alg.EvalRPN(tokens);
            Assert.AreEqual(22, res);
        }
    }
}
