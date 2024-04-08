using leetCode._0501_0550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0501_0550
{
    [TestClass]
    public class _521_LongestUncommonSubsequenceIUnitTest
    {
        _521_LongestUncommonSubsequenceIAlg alg = new _521_LongestUncommonSubsequenceIAlg();
        
        [TestMethod]
        public void TestCase01()
        {
            string a = "aba", b = "cdc";
            int exp = 3;
            int res = alg.FindLUSlength(a, b);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string a = "aaa", b = "bbb";
            int exp = 3;
            int res = alg.FindLUSlength(a, b);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string a = "aaa", b = "aaa";
            int exp = -1;
            int res = alg.FindLUSlength(a, b);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string a = "aefawfawfawfaw", b = "aefawfeawfwafwaef";
            int exp = 17;
            int res = alg.FindLUSlength(a, b);
            Assert.AreEqual(exp, res);
        }
    }
}
