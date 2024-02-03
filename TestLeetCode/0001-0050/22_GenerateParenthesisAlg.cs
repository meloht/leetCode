using leetCode._1_50;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0001_0050
{
    [TestClass]
    public class _22_GenerateParenthesisAlg
    {
        GenerateParenthesisAlg alg = new GenerateParenthesisAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 3;
            string[] exp = ["((()))", "(()())", "(())()", "()(())", "()()()"];
            string[] res = alg.GenerateParenthesis(n).ToArray();
            Assert.IsTrue(Utils.IsSameArr(exp, res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 1;
            string[] exp = ["()"];
            string[] res = alg.GenerateParenthesis(n).ToArray();
            Assert.IsTrue(Utils.IsSameArr(exp, res));
        }
    }
}
