using leetCode._2551_2600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2551_2600
{
    [TestClass]
    public class _2586_CountTheNumberOfVowelStringsInRangeUnitTest
    {
        _2586_CountTheNumberOfVowelStringsInRangeAlg alg = new _2586_CountTheNumberOfVowelStringsInRangeAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] words = ["are", "amy", "u"];
            int left = 0, right = 2;
            int exp = 2;
            int res = alg.VowelStrings(words, left, right);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] words = ["hey", "aeo", "mu", "ooo", "artro"];
            int left = 1, right = 4;
            int exp = 3;
            int res = alg.VowelStrings(words, left, right);
            Assert.AreEqual(exp, res);
        }
    }
}
