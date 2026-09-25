using leetCode._1051_1100;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test._1051_1100
{
    [TestClass]
    public class _1096_BraceExpansionIITest
    {
        _1096_BraceExpansionIIAlg alg = new _1096_BraceExpansionIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            string expression = "{a,b}{c,{d,e}}";
            string[] exp = ["ac", "ad", "ae", "bc", "bd", "be"];
            var res = alg.BraceExpansionII(expression);
            Assert.AreSequenceEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string expression = "{{a,z},a{b,c},{ab,z}}";
            string[] exp = ["a", "ab", "ac", "z"];
            var res = alg.BraceExpansionII(expression);
            Assert.AreSequenceEqual(exp, res);
        }
    }
}
