using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _438_FindAllAnagramsInAStringUnitTest
    {
        _438_FindAllAnagramsInAStringAlg alg = new _438_FindAllAnagramsInAStringAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "cbaebabacd", p = "abc";
            int[] exp = [0, 6];
            int[] res = alg.FindAnagrams(s, p).ToArray();

            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "abab", p = "ab";
            int[] exp = [0, 1, 2];
            int[] res = alg.FindAnagrams(s, p).ToArray();

            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }
        [TestMethod]
        public void TestCase03()
        {
            string s = "aaaaaaaaaa", p = "aaaaaaaaaaaaa";
            int[] exp = [];
            int[] res = alg.FindAnagrams(s, p).ToArray();

            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }

    }
}
