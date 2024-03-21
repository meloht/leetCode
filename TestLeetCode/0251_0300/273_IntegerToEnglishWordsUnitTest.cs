using leetCode._0251_0300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0251_0300
{
    [TestClass]
    public class _273_IntegerToEnglishWordsUnitTest
    {
        _273_IntegerToEnglishWordsAlg alg = new _273_IntegerToEnglishWordsAlg();
        [TestMethod]
        public void TestCase01()
        {
            int num = 123;
            string exp = "One Hundred Twenty Three";
            string res = alg.NumberToWords(num);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int num = 12345;
            string exp = "Twelve Thousand Three Hundred Forty Five";
            string res = alg.NumberToWords(num);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int num = 1234567;
            string exp = "One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven";
            string res = alg.NumberToWords(num);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            int num = 100;
            string exp = "One Hundred";
            string res = alg.NumberToWords(num);
            Assert.AreEqual(exp, res);
        }
    }
}
