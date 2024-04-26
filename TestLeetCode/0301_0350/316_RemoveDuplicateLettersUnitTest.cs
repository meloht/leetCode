using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0301_0350
{
    [TestClass]
    public class _316_RemoveDuplicateLettersUnitTest
    {
        _316_RemoveDuplicateLettersAlg alg = new _316_RemoveDuplicateLettersAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "bcabc";
            string exp = "abc";
            string res = alg.RemoveDuplicateLetters(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "cbacdcbc";
            string exp = "acdb";
            string res = alg.RemoveDuplicateLetters(s);
            Assert.AreEqual(exp, res);
        }
    }
}
