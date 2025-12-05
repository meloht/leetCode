using leetCode._0701_0750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0701_0750
{
    [TestClass]
    public class _730_CountDifferentPalindromicSubsequencesTest
    {
        _730_CountDifferentPalindromicSubsequencesAlg alg = new _730_CountDifferentPalindromicSubsequencesAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "bccb";
            int exp = 6;
            int res = alg.CountPalindromicSubsequences(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "abcdabcdabcdabcdabcdabcdabcdabcddcbadcbadcbadcbadcbadcbadcbadcba";
            int exp = 104860361;
            int res = alg.CountPalindromicSubsequences(s);
            Assert.AreEqual(exp, res);
        }
    }
}
