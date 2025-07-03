using leetCode._3301_3350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3301_3350
{
    public class _3304_FindTheKThCharacterInStringGameITest
    {
        _3304_FindTheKThCharacterInStringGameIAlg alg = new _3304_FindTheKThCharacterInStringGameIAlg();

        [Fact]
        public void Test01()
        {
            int k = 5;
            char exp = 'b';
            char res = alg.KthCharacter(k);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int k = 10;
            char exp = 'c';
            char res = alg.KthCharacter(k);
            Assert.Equal(exp, res);
        }
    }
}
