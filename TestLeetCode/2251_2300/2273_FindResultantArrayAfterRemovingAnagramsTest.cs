using leetCode._2251_2300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2251_2300
{
    [TestClass]
    public class _2273_FindResultantArrayAfterRemovingAnagramsTest
    {
        _2273_FindResultantArrayAfterRemovingAnagramsAlg alg = new _2273_FindResultantArrayAfterRemovingAnagramsAlg();


        [TestMethod]
        public void TestCase01()
        {
            string[] words = ["abba", "baba", "bbaa", "cd", "cd"];
            string[] exp = ["abba", "cd"];
            string[] res = alg.RemoveAnagrams(words).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }
        [TestMethod]
        public void TestCase02()
        {
            string[] words = ["a", "b", "c", "d", "e"];
            string[] exp = ["a", "b", "c", "d", "e"];
            string[] res = alg.RemoveAnagrams(words).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }

    }
}
