using leetCode._3301_3350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3301_3350
{
    public class _3330_FindTheOriginalTypedStringITest
    {
        _3330_FindTheOriginalTypedStringIAlg alg = new _3330_FindTheOriginalTypedStringIAlg();

        [Fact]
        public void Test01()
        {
            string word = "abbcccc";
            int exp = 5;
            int res = alg.PossibleStringCount(word);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            string word = "abcd";
            int exp = 1;
            int res = alg.PossibleStringCount(word);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            string word = "aaaa";
            int exp = 4;
            int res = alg.PossibleStringCount(word);
            Assert.Equal(exp, res);
        }
    }
}
