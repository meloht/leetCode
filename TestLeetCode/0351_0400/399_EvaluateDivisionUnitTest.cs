using leetCode._0351_0400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0351_0400
{
    [TestClass]
    public class _399_EvaluateDivisionUnitTest
    {
        _399_EvaluateDivisionAlg alg = new _399_EvaluateDivisionAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[][] equations = [["a", "b"], ["b", "c"]];
            double[] values = [2.0, 3.0];
            string[][] queries = [["a", "c"], ["b", "a"], ["a", "e"], ["a", "a"], ["x", "x"]];
            double[] exp = [6.00000, 0.50000, -1.00000, 1.00000, -1.00000];
            double[] res = alg.CalcEquation(equations, values, queries);
            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            string[][] equations = [["a", "b"], ["b", "c"], ["bc", "cd"]];
            double[] values = [1.5, 2.5, 5.0];
            string[][] queries = [["a", "c"], ["c", "b"], ["bc", "cd"], ["cd", "bc"]];
            double[] exp = [3.75000, 0.40000, 5.00000, 0.20000];
            double[] res = alg.CalcEquation(equations, values, queries);
            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            string[][] equations = [["a", "b"]];
            double[] values = [0.5];
            string[][] queries = [["a", "b"], ["b", "a"], ["a", "c"], ["x", "y"]];
            double[] exp = [0.50000, 2.00000, -1.00000, -1.00000];
            double[] res = alg.CalcEquation(equations, values, queries);
            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }
    }
}
