using leetCode._0351_0400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0351_0400
{
    [TestClass]
    public class _394_DecodeStringUnitTest
    {
        _394_DecodeStringAlg alg = new _394_DecodeStringAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "3[a]2[bc]";
            string exp = "aaabcbc";
            var res = alg.DecodeString(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "3[a2[c]]";
            string exp = "accaccacc";
            var res = alg.DecodeString(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "2[abc]3[cd]ef";
            string exp = "abcabccdcdcdef";
            var res = alg.DecodeString(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string s = "abc3[cd]xyz";
            string exp = "abccdcdcdxyz";
            var res = alg.DecodeString(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            string s = "3[z]2[2[y]pq4[2[jk]e1[f]]]ef";
            string exp = "zzzyypqjkjkefjkjkefjkjkefjkjkefyypqjkjkefjkjkefjkjkefjkjkefef";
            var res = alg.DecodeString(s);
            Assert.AreEqual(exp, res);
        }
    }
}
