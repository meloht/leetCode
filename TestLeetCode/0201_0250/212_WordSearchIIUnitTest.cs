using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0201_0250
{
    [TestClass]
    public class _212_WordSearchIIUnitTest
    {
        _212_WordSearchIIAlg alg = new _212_WordSearchIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            char[][] board = [['o', 'a', 'a', 'n'], ['e', 't', 'a', 'e'], ['i', 'h', 'k', 'r'], ['i', 'f', 'l', 'v']];
            string[] words = ["oath", "pea", "eat", "rain"];
            string[] exp = ["eat", "oath"];
            var res = alg.FindWords(board, words);
            Assert.IsTrue(exp.SequenceEqual(res));
        }


        [TestMethod]
        public void TestCase02()
        {
            char[][] board = [['a', 'b'], ['c', 'd']];
            string[] words = ["abcb"];
            string[] exp = [];
            var res = alg.FindWords(board, words);
            Assert.IsTrue(exp.SequenceEqual(res));

        }
    }
}
