using leetCode._0851_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0851_0900
{
    
    public class _866_PrimePalindromeTest
    {
        _866_PrimePalindromeAlg alg = new _866_PrimePalindromeAlg();

        [Fact]
        public void Test01()
        {
            int n = 6;
            int exp = 7;
            int res = alg.PrimePalindrome(n);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int n = 8;
            int exp = 11;
            int res = alg.PrimePalindrome(n);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int n = 13;
            int exp = 101;
            int res = alg.PrimePalindrome(n);
            Assert.Equal(exp, res);
        }
    }
}
