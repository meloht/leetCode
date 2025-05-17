using leetCode._2851_2900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._2851_2900
{
    public class _2900_LongestUnequalAdjacentGroupsSubsequenceITest
    {
        _2900_LongestUnequalAdjacentGroupsSubsequenceIAlg alg = new _2900_LongestUnequalAdjacentGroupsSubsequenceIAlg();

        [Fact]
        public void Test01()
        {
            string[] words = ["e", "a", "b"];
            int[] groups = [0, 0, 1];
            string[] exp = ["a", "b"];
            string[] res = alg.GetLongestSubsequence(words, groups).ToArray();
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            string[] words = ["a", "b", "c", "d"];
            int[] groups = [1, 0, 1, 1];
            string[] exp = ["a", "b", "d"];
            string[] res = alg.GetLongestSubsequence(words, groups).ToArray();
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            string[] words = ["d", "g"];
            int[] groups = [0, 1];
            string[] exp = ["d", "g"];
            string[] res = alg.GetLongestSubsequence(words, groups).ToArray();
            Assert.Equal(exp, res);
        }
    }
}
