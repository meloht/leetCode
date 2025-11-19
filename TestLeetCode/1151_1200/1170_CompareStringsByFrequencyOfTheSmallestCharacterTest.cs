using leetCode._1151_1200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1151_1200
{
    [TestClass]
    public class _1170_CompareStringsByFrequencyOfTheSmallestCharacterTest
    {
        _1170_CompareStringsByFrequencyOfTheSmallestCharacterAlg alg = new _1170_CompareStringsByFrequencyOfTheSmallestCharacterAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] queries = ["cbd"], words = ["zaaaz"];
            int[] exp = [1];
            int[] res = alg.NumSmallerByFrequency(queries, words);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] queries = ["bbb", "cc"], words = ["a", "aa", "aaa", "aaaa"];
            int[] exp = [1, 2];
            int[] res = alg.NumSmallerByFrequency(queries, words);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            string[] queries = ["aabbabbb", "abbbabaa", "aabbbabaa", "aabba", "abb", "a", "ba", "aa", "ba", "baabbbaaaa", "babaa", "bbbbabaa"];
            string[] words = ["b", "aaaba", "aaaabba", "aa", "aabaabab", "aabbaaabbb", "ababb", "bbb", "aabbbabb", "aab", "bbaaababba", "baaaaa"];
            int[] exp = [6, 5, 0, 6, 11, 11, 11, 8, 11, 0, 6, 6];
            int[] res = alg.NumSmallerByFrequency(queries, words);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
