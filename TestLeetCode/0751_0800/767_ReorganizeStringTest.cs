using leetCode._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0751_0800
{
    [TestClass]
    public class _767_ReorganizeStringTest
    {
        _767_ReorganizeStringAlg alg = new _767_ReorganizeStringAlg();

        private bool CheckString(string s)
        {
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i - 1] == s[i])
                    return false;

            }
            return true;
        }
        [TestMethod]
        public void TestCase01()
        {
            string s = "aab";
            string exp = "aba";
            string res = alg.ReorganizeString(s);
            Assert.IsTrue(CheckString(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "aaab";
            string exp = "";
            string res = alg.ReorganizeString(s);
            Assert.IsTrue(CheckString(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "ogccckcwmbmxtsbmozli";
            string exp = "cmcmcmcbobotsxzlkigw";
            string res = alg.ReorganizeString(s);
            Assert.IsTrue(CheckString(res));
        }

        [TestMethod]
        public void TestCase04()
        {
            string s = "aabbcc";
            string exp = "abacbc";
            string res = alg.ReorganizeString(s);
            Assert.IsTrue(CheckString(res));
        }

        [TestMethod]
        public void TestCase05()
        {
            string s = "aaaaaaccccbbb";
            string exp = "abacbc";
            string res = alg.ReorganizeString(s);
            Assert.IsTrue(CheckString(res));
        }
    }
}
