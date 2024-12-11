using leetCode._0601_0650;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0601_0650
{
    [TestClass]
    public class _640_SolveTheEquationTest
    {
        _640_SolveTheEquationAlg alg = new _640_SolveTheEquationAlg();


        [TestMethod]
        public void TestCase01()
        {
            string equation = "x+5-3+x=6+x-2";
            string exp = "x=2";
            string res = alg.SolveEquation(equation);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string equation = "x=x";
            string exp = "Infinite solutions";
            string res = alg.SolveEquation(equation);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string equation = "2x=x";
            string exp = "x=0";
            string res = alg.SolveEquation(equation);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase04()
        {
            string equation = "-x=-1";
            string exp = "x=1";
            string res = alg.SolveEquation(equation);
            Assert.AreEqual(exp, res);
        }
    }
}
