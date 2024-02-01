using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0101_0150
{
    [TestClass]
    public class _125_ValidPalindromeUnitTest
    {
        _125_ValidPalindromeAlg alg = new _125_ValidPalindromeAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "A man, a plan, a canal: Panama";
            bool bl = alg.IsPalindrome(s);
            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "race a car";
            bool bl = alg.IsPalindrome(s);
            Assert.AreEqual(false, bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = " ";
            bool bl = alg.IsPalindrome(s);
            Assert.AreEqual(true, bl);
        }
    }
}
