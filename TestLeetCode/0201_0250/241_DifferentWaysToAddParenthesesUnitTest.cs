using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0201_0250
{
    [TestClass]
    public class _241_DifferentWaysToAddParenthesesUnitTest
    {
        _241_DifferentWaysToAddParenthesesAlg alg = new _241_DifferentWaysToAddParenthesesAlg();

        [TestMethod]
        public void TestCase01()
        {
            string expression = "2-1-1";
            int[] exp = [0, 2];
            int[] res = alg.DiffWaysToCompute(expression).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            string expression = "2*3-4*5";
            int[] exp = [-34, -14, -10, -10, 10];
            int[] res = alg.DiffWaysToCompute(expression).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
