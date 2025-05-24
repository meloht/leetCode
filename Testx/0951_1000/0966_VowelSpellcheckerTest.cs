using leetCode._0951_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0951_1000
{
    public class _0966_VowelSpellcheckerTest
    {
        _0966_VowelSpellcheckerAlg alg = new _0966_VowelSpellcheckerAlg();

        [Fact]
        public void Test01()
        {
            string[] wordlist = ["KiTe", "kite", "hare", "Hare"], queries = ["kite", "Kite", "KiTe", "Hare", "HARE", "Hear", "hear", "keti", "keet", "keto"];
            string[] exp = ["kite", "KiTe", "KiTe", "Hare", "hare", "", "", "KiTe", "", "KiTe"];
            string[] res = alg.Spellchecker(wordlist, queries);
            Assert.Equal(exp, res);
           
        }

        [Fact]
        public void Test02()
        {
            string[] wordlist = ["yellow"], queries = ["YellOw"];
            string[] exp = ["yellow"];
            string[] res = alg.Spellchecker(wordlist, queries);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            string[] wordlist = ["ae", "aa"], queries = ["UU"];
            string[] exp = ["ae"];
            string[] res = alg.Spellchecker(wordlist, queries);
            Assert.Equal(exp, res);
        }
    }
}
