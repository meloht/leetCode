using leetCode._1051_1100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1051_1100
{
    [TestClass]
    public class _1061_LexicographicallySmallestEquivalentStringUnitTest
    {
        _1061_LexicographicallySmallestEquivalentStringAlg alg = new _1061_LexicographicallySmallestEquivalentStringAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s1 = "parker", s2 = "morris", baseStr = "parser";
            string exp = "makkek";
            string res = alg.SmallestEquivalentString(s1, s2, baseStr);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s1 = "hello", s2 = "world", baseStr = "hold";
            string exp = "hdld";
            string res = alg.SmallestEquivalentString(s1, s2, baseStr);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s1 = "leetcode", s2 = "programs", baseStr = "sourcecode";
            string exp = "aauaaaaada";
            string res = alg.SmallestEquivalentString(s1, s2, baseStr);
            Assert.AreEqual(exp, res);
        }
    }
}
