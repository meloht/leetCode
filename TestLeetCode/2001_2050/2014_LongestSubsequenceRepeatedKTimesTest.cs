using leetCode._2001_2050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2001_2050
{
    [TestClass]
    public class _2014_LongestSubsequenceRepeatedKTimesTest
    {
        _2014_LongestSubsequenceRepeatedKTimesAlg alg = new _2014_LongestSubsequenceRepeatedKTimesAlg();

        [TestMethod]
        public void Test01()
        {
            string s = "letsleetcode";
            int k = 2;
            string exp = "let";
            string res = alg.LongestSubsequenceRepeatedK(s, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test02()
        {
            string s = "bb";
            int k = 2;
            string exp = "b";
            string res = alg.LongestSubsequenceRepeatedK(s, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test03()
        {
            string s = "ab";
            int k = 2;
            string exp = "";
            string res = alg.LongestSubsequenceRepeatedK(s, k);
            Assert.AreEqual(exp, res);
        }
    }
}
