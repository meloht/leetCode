using leetCode._2901_2950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._2901_2950
{
    public class _2901_LongestUnequalAdjacentGroupsSubsequenceIITest
    {
        _2901_LongestUnequalAdjacentGroupsSubsequenceIIAlg alg = new _2901_LongestUnequalAdjacentGroupsSubsequenceIIAlg();


        [Fact]
        public void Test01()
        {
            int n = 3;
            string[] words = ["bab", "dab", "cab"];
            int[] groups = [1, 2, 2];
            string[] exp = ["bab", "cab"];
            string[] resk = alg.GetWordsInLongestSubsequence(words, groups).ToArray();
            Assert.Equal(exp, resk);
        }

        [Fact]
        public void Test02()
        {
            int n = 4;
            string[] words = ["a", "b", "c", "d"];
            int[] groups = [1, 2, 3, 4];
            string[] exp = ["a", "b", "c", "d"];
            string[] resk = alg.GetWordsInLongestSubsequence(words, groups).ToArray();
            Assert.Equal(exp, resk);
        }
    }
}
