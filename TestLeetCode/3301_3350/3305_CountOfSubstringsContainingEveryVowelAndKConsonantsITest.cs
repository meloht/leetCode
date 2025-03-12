using leetCode._3301_3350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3301_3350
{
    [TestClass]
    public class _3305_CountOfSubstringsContainingEveryVowelAndKConsonantsITest
    {
        _3305_CountOfSubstringsContainingEveryVowelAndKConsonantsIAlg alg = new _3305_CountOfSubstringsContainingEveryVowelAndKConsonantsIAlg();

        [TestMethod]
        public void TestCase01()
        {
            string word = "aeioqq";
            int k = 1;
            int exp = 0;
            int res = alg.CountOfSubstrings(word, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string word = "aeiou";
            int k = 0;
            int exp = 1;
            int res = alg.CountOfSubstrings(word, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string word = "ieaouqqieaouqq";
            int k = 1;
            int exp = 3;
            int res = alg.CountOfSubstrings(word, k);
            Assert.AreEqual(exp, res);
        }
    }
}
