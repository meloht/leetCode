using leetCode._2701_2750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2701_2750
{
    [TestClass]
    public class _2734_LexicographicallySmallestStringAfterSubstringOperationTest
    {
        _2734_LexicographicallySmallestStringAfterSubstringOperationAlg alg = new _2734_LexicographicallySmallestStringAfterSubstringOperationAlg();
        [TestMethod]
        public void TestCase01()
        {
            string s = "cbabc";
            string exp = "baabc";
            string res = alg.SmallestString(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "acbbc";
            string exp = "abaab";
            string res = alg.SmallestString(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "leetcode";
            string exp = "kddsbncd";
            string res = alg.SmallestString(s);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            string s = "aa";
            string exp = "az";
            string res = alg.SmallestString(s);
            Assert.AreEqual(exp, res);
        }
    }
}
