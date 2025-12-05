using leetCode._0701_0750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0701_0750
{
    [TestClass]
    public class _736_ParseLispExpressionTest
    {
        _736_ParseLispExpressionAlg alg = new _736_ParseLispExpressionAlg();

        [TestMethod]
        public void TestCase01()
        {
            string expression = "(let x 2 (mult x (let x 3 y 4 (add x y))))";
            int exp = 14;
            int res = alg.Evaluate(expression);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string expression = "(let x 3 x 2 x)";
            int exp = 2;
            int res = alg.Evaluate(expression);
            Assert.AreEqual(exp, res);
        }
    }
}
