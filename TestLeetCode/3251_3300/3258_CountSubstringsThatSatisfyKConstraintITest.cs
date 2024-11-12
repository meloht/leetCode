using leetCode._3251_3300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3251_3300
{
    [TestClass]
    public class _3258_CountSubstringsThatSatisfyKConstraintITest
    {
        _3258_CountSubstringsThatSatisfyKConstraintIAlg alg = new _3258_CountSubstringsThatSatisfyKConstraintIAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "10101";
            int k = 1;
            int exp = 12;
            int res = alg.CountKConstraintSubstrings(s, 1);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "1010101";
            int k = 2;
            int exp = 25;
            int res = alg.CountKConstraintSubstrings(s, 1);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "11111";
            int k = 1;
            int exp = 15;
            int res = alg.CountKConstraintSubstrings(s, 1);
            Assert.AreEqual(exp, res);
        }
    }
}
