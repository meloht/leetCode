using leetCode._1051_1100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1051_1100
{
    [TestClass]
    public class _1071_GreatestCommonDivisorOfStringsTest
    {
        _1071_GreatestCommonDivisorOfStringsAlg alg = new _1071_GreatestCommonDivisorOfStringsAlg();
        [TestMethod]
        public void TestCase01()
        {
            string str1 = "ABCABC", str2 = "ABC";
            string exp = "ABC";
            string res=alg.GcdOfStrings(str1, str2);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase02()
        {
            string str1 = "ABABAB", str2 = "ABAB";
            string exp = "AB";
            string res = alg.GcdOfStrings(str1, str2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string str1 = "LEET", str2 = "CODE";
            string exp = "";
            string res = alg.GcdOfStrings(str1, str2);
            Assert.AreEqual(exp, res);
        }
    }
}
