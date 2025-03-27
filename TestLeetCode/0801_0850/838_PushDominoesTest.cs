using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _838_PushDominoesTest
    {
        _838_PushDominoesAlg alg = new _838_PushDominoesAlg();


        [TestMethod]
        public void TestCase01()
        {
            string dominoes = "RR.L";
            string exp = "RR.L";
            string res = alg.PushDominoes(dominoes);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string dominoes = ".L.R...LR..L..";
            string exp = "LL.RR.LLRRLL..";
            string res = alg.PushDominoes(dominoes);
            Assert.AreEqual(exp, res);
        }
    }
}
