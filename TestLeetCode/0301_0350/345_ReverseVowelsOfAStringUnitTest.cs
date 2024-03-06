using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0301_0350
{
    [TestClass]
    public class _345_ReverseVowelsOfAStringUnitTest
    {
        _345_ReverseVowelsOfAStringAlg alg = new _345_ReverseVowelsOfAStringAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "hello";
            string exp = "holle";
            string res = alg.ReverseVowels(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "leetcode";
            string exp = "leotcede";
            string res = alg.ReverseVowels(s);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase03()
        {
            string s = " ";
            string exp = " ";
            string res = alg.ReverseVowels(s);
            Assert.AreEqual(exp, res);
        }
    }
}
