using leetCode._0501_0550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0501_0550
{
    [TestClass]
    public class _522_LongestUncommonSubsequenceIITest
    {
        _522_LongestUncommonSubsequenceIIAlg alg = new _522_LongestUncommonSubsequenceIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] strs = ["aba", "cdc", "eae"];
            int exp = 3;
            int res = alg.FindLUSlength(strs);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] strs = ["aaa", "aaa", "aa"];
            int exp = -1;
            int res = alg.FindLUSlength(strs);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string[] strs = ["aabbcc", "aabbcc", "cb"];
            int exp = 2;
            int res = alg.FindLUSlength(strs);
            Assert.AreEqual(exp, res);
        }
    }
}
