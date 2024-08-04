using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _472_ConcatenatedWordsTest
    {
        _472_ConcatenatedWordsAlg alg = new _472_ConcatenatedWordsAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] words = ["cat", "cats", "catsdogcats", "dog", "dogcatsdog", "hippopotamuses", "rat", "ratcatdogcat"];
            string[] exp = ["catsdogcats", "dogcatsdog", "ratcatdogcat"];
            string[] res = alg.FindAllConcatenatedWordsInADict(words).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] words = ["cat", "dog", "catdog"];
            string[] exp = ["catdog"];
            string[] res = alg.FindAllConcatenatedWordsInADict(words).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            string[] words = ["a", "b", "ab", "abc"];
            string[] exp = ["ab"];
            string[] res = alg.FindAllConcatenatedWordsInADict(words).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
