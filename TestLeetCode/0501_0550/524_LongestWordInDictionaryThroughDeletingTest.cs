using leetCode._0501_0550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0501_0550
{
    [TestClass]
    public class _524_LongestWordInDictionaryThroughDeletingTest
    {
        _524_LongestWordInDictionaryThroughDeletingAlg alg = new _524_LongestWordInDictionaryThroughDeletingAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "abpcplea";
            string[] dictionary = ["ale", "apple", "monkey", "plea"];
            string exp = "apple";
            string res = alg.FindLongestWord(s, dictionary);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "abpcplea";
            string[] dictionary = ["a", "b", "c"];
            string exp = "a";
            string res = alg.FindLongestWord(s, dictionary);
            Assert.AreEqual(exp, res);
        }
    }
}
