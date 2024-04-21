using leetCode._0901_0950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0901_0950
{
    [TestClass]
    public class _917_ReverseOnlyLettersUnitTest
    {
        _917_ReverseOnlyLettersAlg alg = new _917_ReverseOnlyLettersAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "ab-cd";
            string exp = "dc-ba";
            string res = alg.ReverseOnlyLetters(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "a-bC-dEf-ghIj";
            string exp = "j-Ih-gfE-dCba";
            string res = alg.ReverseOnlyLetters(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "Test1ng-Leet=code-Q!";
            string exp = "Qedo1ct-eeLg=ntse-T!";
            string res = alg.ReverseOnlyLetters(s);
            Assert.AreEqual(exp, res);
        }
    }
}
