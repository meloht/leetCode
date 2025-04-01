using leetCode._0851_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0851_0900
{
    public class _856_ScoreOfParenthesesTest
    {
        _856_ScoreOfParenthesesAlg alg = new _856_ScoreOfParenthesesAlg();

        [Fact]
        public void Test01()
        {
            string s = "()";
            int exp = 1;
            int res = alg.ScoreOfParentheses(s);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            string s = "(())";
            int exp = 2;
            int res = alg.ScoreOfParentheses(s);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            string s = "()()";
            int exp = 2;
            int res = alg.ScoreOfParentheses(s);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test04()
        {
            string s = "(()(()))";
            int exp = 6;
            int res = alg.ScoreOfParentheses(s);
            Assert.Equal(exp, res);
        }
    }
}
