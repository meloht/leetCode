using leetCode._0901_0950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0901_0950
{
    public class _916_WordSubsetsTest
    {
        _916_WordSubsetsAlg alg = new _916_WordSubsetsAlg();

        [Fact]
        public void Test01()
        {
            string[] words1 = ["amazon", "apple", "facebook", "google", "leetcode"], words2 = ["e", "o"];
            string[] exp = ["facebook", "google", "leetcode"];
            string[] res = alg.WordSubsets(words1, words2).ToArray();
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            string[] words1 = ["amazon", "apple", "facebook", "google", "leetcode"], words2 = ["lc", "eo"];
            string[] exp = ["leetcode"];
            string[] res = alg.WordSubsets(words1, words2).ToArray();
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            string[] words1 = ["acaac", "cccbb", "aacbb", "caacc", "bcbbb"], words2 = ["c", "cc", "b"];
            string[] exp = ["cccbb"];
            string[] res = alg.WordSubsets(words1, words2).ToArray();
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test04()
        {
            string[] words1 = ["amazon", "apple", "facebook", "google", "leetcode"], words2 = ["lo", "eo"];
            string[] exp = ["google", "leetcode"];
            string[] res = alg.WordSubsets(words1, words2).ToArray();
            Assert.Equal(exp, res);
        }
    }
}
