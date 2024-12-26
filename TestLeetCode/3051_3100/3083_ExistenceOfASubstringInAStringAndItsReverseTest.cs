using leetCode._3051_3100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3051_3100
{
    [TestClass]
    public class _3083_ExistenceOfASubstringInAStringAndItsReverseTest
    {
        _3083_ExistenceOfASubstringInAStringAndItsReverseAlg alg = new _3083_ExistenceOfASubstringInAStringAndItsReverseAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "leetcode";
            bool exp = true;
            bool res = alg.IsSubstringPresent(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "abcba";
            bool exp = true;
            bool res = alg.IsSubstringPresent(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "abcd";
            bool exp = false;
            bool res = alg.IsSubstringPresent(s);
            Assert.AreEqual(exp, res);
        }
    }
}
