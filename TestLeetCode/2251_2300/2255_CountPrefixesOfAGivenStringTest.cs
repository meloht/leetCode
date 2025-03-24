using leetCode._2251_2300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2251_2300
{
    [TestClass]
    public class _2255_CountPrefixesOfAGivenStringTest
    {
        _2255_CountPrefixesOfAGivenStringAlg alg = new _2255_CountPrefixesOfAGivenStringAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] words = ["a", "b", "c", "ab", "bc", "abc"];
            string s = "abc";
            int exp = 3;
            int res = alg.CountPrefixes(words,s);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase02()
        {
            string[] words = ["a", "a"];
            string s = "aa";
            int exp = 2;
            int res = alg.CountPrefixes(words, s);
            Assert.AreEqual(exp, res);
        }
    }
}
