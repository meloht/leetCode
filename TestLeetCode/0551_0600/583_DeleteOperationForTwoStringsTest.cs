using leetCode._0551_0600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0551_0600
{
    [TestClass]
    public class _583_DeleteOperationForTwoStringsTest
    {
        _583_DeleteOperationForTwoStringsAlg alg = new _583_DeleteOperationForTwoStringsAlg();

        [TestMethod]
        public void TestCase01()
        {
            string word1 = "sea", word2 = "eat";
            int exp = 2;
            int res = alg.MinDistance(word1, word2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string word1 = "leetcode", word2 = "etco";
            int exp = 4;
            int res = alg.MinDistance(word1, word2);
            Assert.AreEqual(exp, res);
        }
    }
}
