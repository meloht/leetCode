using leetCode._0951_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0951_1000
{
    [TestClass]
    public class _0990_SatisfiabilityOfEqualityEquationsUnitTest
    {
        _0990_SatisfiabilityOfEqualityEquationsAlg alg = new _0990_SatisfiabilityOfEqualityEquationsAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] equations = ["a==b", "b!=a"];
            bool exp = false;
            bool res = alg.EquationsPossible(equations);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] equations = ["b==a", "a==b"];
            bool exp = true;
            bool res = alg.EquationsPossible(equations);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string[] equations = ["a==b", "b==c", "a==c"];
            bool exp = true;
            bool res = alg.EquationsPossible(equations);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase04()
        {
            string[] equations = ["a==b", "b!=c", "c==a"];
            bool exp = false;
            bool res = alg.EquationsPossible(equations);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            string[] equations = ["c==c", "b==d", "x!=z"];
            bool exp = true;
            bool res = alg.EquationsPossible(equations);
            Assert.AreEqual(exp, res);
        }
    }
}
