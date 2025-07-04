using leetCode._3301_3350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3301_3350
{
    public class _3307_FindTheKThCharacterInStringGameIITest
    {
        _3307_FindTheKThCharacterInStringGameIIAlg alg = new _3307_FindTheKThCharacterInStringGameIIAlg();

        [Fact]
        public void Test01()
        {
            long k = 5;
            int[] operations = [0, 0, 0];
            char exp = 'a';
            char res = alg.KthCharacter(k, operations);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            long k = 10;
            int[] operations = [0, 1, 0, 1];
            char exp = 'b';
            char res = alg.KthCharacter(k, operations);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            long k = 12145134613;
            int[] operations = [0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 1, 0, 1, 0, 0, 1, 1, 1, 1, 1];
            char exp = 'i';
            char res = alg.KthCharacter(k, operations);
            Assert.Equal(exp, res);
        }
    }
}
