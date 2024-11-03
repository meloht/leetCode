using leetCode._0551_0600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0551_0600
{
    [TestClass]
    public class _564_FindTheClosestPalindromeTest
    {
        _564_FindTheClosestPalindromeAlg alg = new _564_FindTheClosestPalindromeAlg();

        [TestMethod]
        public void TestCase01()
        {
            string n = "123";
            string exp = "123";
            string res = alg.NearestPalindromic(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string n = "1";
            string exp = "0";
            string res = alg.NearestPalindromic(n);
            Assert.AreEqual(exp, res);
        }
    }
}
