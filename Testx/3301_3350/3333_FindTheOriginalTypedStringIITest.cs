using leetCode._3301_3350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3301_3350
{
    public class _3333_FindTheOriginalTypedStringIITest
    {
        _3333_FindTheOriginalTypedStringIIAlg alg = new _3333_FindTheOriginalTypedStringIIAlg();

        [Fact]
        public void Test01()
        {
            string word = "aabbccdd";
            int k = 7;
            int exp = 5;
            int res = alg.PossibleStringCount(word, k);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            string word = "aabbccdd";
            int k = 8;
            int exp = 1;
            int res = alg.PossibleStringCount(word, k);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            string word = "aaabbb";
            int k = 3;
            int exp = 8;
            int res = alg.PossibleStringCount(word, k);
            Assert.Equal(exp, res);
        }
    }
}
