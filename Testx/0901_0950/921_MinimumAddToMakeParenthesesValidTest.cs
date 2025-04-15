using leetCode._0901_0950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0901_0950
{
    public class _921_MinimumAddToMakeParenthesesValidTest
    {
        _921_MinimumAddToMakeParenthesesValidAlg alg = new _921_MinimumAddToMakeParenthesesValidAlg();
        
        [Fact]
        public void Test01()
        {
            string s = "())";
            int exp = 1;
            int res = alg.MinAddToMakeValid(s);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            string s = "(((";
            int exp = 3;
            int res = alg.MinAddToMakeValid(s);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            string s = "()))((";
            int exp = 4;
            int res = alg.MinAddToMakeValid(s);
            Assert.Equal(exp, res);
        }
    }
}
