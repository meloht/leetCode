using leetCode._1301_1350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1301_1350
{
    [TestClass]
    public class _1328_BreakAPalindromeTest
    {
        _1328_BreakAPalindromeAlg alg = new _1328_BreakAPalindromeAlg();

        [TestMethod]
        public void TestCase01()
        {
            string palindrome = "abccba";
            string exp = "aaccba";
            string res = alg.BreakPalindrome(palindrome);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string palindrome = "a";
            string exp = "";
            string res = alg.BreakPalindrome(palindrome);
            Assert.AreEqual(exp, res);
        }
    }
}
