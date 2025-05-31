using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1001_1050
{
    [TestClass]
    public class _1003_CheckIfWordIsValidAfterSubstitutionsTest
    {
        _1003_CheckIfWordIsValidAfterSubstitutionsAlg alg = new _1003_CheckIfWordIsValidAfterSubstitutionsAlg();
        [TestMethod]
        public void TestCase01()
        {
            string s = "aabcbc";
            bool exp = true;
            bool res= alg.IsValid(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "abcabcababcc";
            bool exp = true;
            bool res = alg.IsValid(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "abccba";
            bool exp = false;
            bool res = alg.IsValid(s);
            Assert.AreEqual(exp, res);
        }
    }
}
