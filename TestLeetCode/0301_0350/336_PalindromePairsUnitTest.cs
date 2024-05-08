using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0301_0350
{
    [TestClass]
    public class _336_PalindromePairsUnitTest
    {
        _336_PalindromePairsAlg alg = new _336_PalindromePairsAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] words = ["abcd", "dcba", "lls", "s", "sssll"];
            IList<IList<int>> exp = [[0, 1], [1, 0], [3, 2], [2, 4]];
            IList<IList<int>> res = alg.PalindromePairs(words);

            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);

        }

        [TestMethod]
        public void TestCase02()
        {
            string[] words = ["bat", "tab", "cat"];
            IList<IList<int>> exp = [[0, 1], [1, 0]];
            IList<IList<int>> res = alg.PalindromePairs(words);

            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);

        }

        [TestMethod]
        public void TestCase03()
        {
            string[] words = ["a", ""];
            IList<IList<int>> exp = [[0, 1], [1, 0]];
            IList<IList<int>> res = alg.PalindromePairs(words);

            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);

        }
    }
}
