using leetCode._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0751_0800
{
    [TestClass]
    public class _792_NumberOfMatchingSubsequencesTest
    {
        _792_NumberOfMatchingSubsequencesAlg alg=new _792_NumberOfMatchingSubsequencesAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "abcde";
            string[] words = new string[] { "a", "bb", "acd", "ace" };
            int exp = 3;
            int res = alg.NumMatchingSubseq(s, words);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "dsahjpjauf";
            string[] words = ["ahjpjau", "ja", "ahbwzgqnuk", "tnmlanowax"];
            int exp = 2;
            int res = alg.NumMatchingSubseq(s, words);
            Assert.AreEqual(exp, res);
        }

    }
}
