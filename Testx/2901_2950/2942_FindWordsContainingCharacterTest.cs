using leetCode._2901_2950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._2901_2950
{
    public class _2942_FindWordsContainingCharacterTest
    {
        _2942_FindWordsContainingCharacterAlg alg = new _2942_FindWordsContainingCharacterAlg();
        [Fact]
        public void Test01()
        {
            string[] words = ["leet", "code"];
            char x = 'e';
            int[] exp = [0, 1];
            int[] res = alg.FindWordsContaining(words, x).ToArray();
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            string[] words = ["abc", "bcd", "aaaa", "cbc"];
            char x = 'z';
            int[] exp = [];
            int[] res = alg.FindWordsContaining(words, x).ToArray();
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            string[] words = ["abc", "bcd", "aaaa", "cbc"];
            char x = 'a';
            int[] exp = [0, 2];
            int[] res = alg.FindWordsContaining(words, x).ToArray();
            Assert.Equal(exp, res);
        }
    }
}
