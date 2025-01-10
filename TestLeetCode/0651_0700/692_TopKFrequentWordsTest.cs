using leetCode._0651_0700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0651_0700
{
    [TestClass]
    public class _692_TopKFrequentWordsTest
    {
        _692_TopKFrequentWordsAlg alg = new _692_TopKFrequentWordsAlg();
        [TestMethod]
        public void TestCase01()
        {
            string[] words = ["i", "love", "leetcode", "i", "love", "coding"];
            int k = 2;
            string[] exp = ["i", "love"];
            string[] res = alg.TopKFrequent(words, k).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] words = ["the", "day", "is", "sunny", "the", "the", "the", "sunny", "is", "is"];
            int k = 4;
            string[] exp = ["the", "is", "sunny", "day"];
            string[] res = alg.TopKFrequent(words, k).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
