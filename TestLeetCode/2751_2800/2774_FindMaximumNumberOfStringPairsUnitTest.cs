using leetCode._2751_2800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._2751_2800
{
    [TestClass]
    public class _2774_FindMaximumNumberOfStringPairsUnitTest
    {
        _2774_FindMaximumNumberOfStringPairsAlg alg = new _2774_FindMaximumNumberOfStringPairsAlg();
        
        [TestMethod]
        public void TestCase01()
        {
            string[] words = ["cd", "ac", "dc", "ca", "zz"];
            int exp = 2;
            int res = alg.MaximumNumberOfStringPairs(words);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] words = ["ab", "ba", "cc"];
            int exp = 1;
            int res = alg.MaximumNumberOfStringPairs(words);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string[] words = ["aa", "ab"];
            int exp = 0;
            int res = alg.MaximumNumberOfStringPairs(words);
            Assert.AreEqual(exp, res);
        }
    }
}
