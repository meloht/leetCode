using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _479_LargestPalindromeProductTest
    {
        _479_LargestPalindromeProductAlg alg = new _479_LargestPalindromeProductAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 2;
            int exp = 987;
            int res = alg.LargestPalindrome(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 1;
            int exp = 9;
            int res = alg.LargestPalindrome(n);
            Assert.AreEqual(exp, res);
        }
    }
}
