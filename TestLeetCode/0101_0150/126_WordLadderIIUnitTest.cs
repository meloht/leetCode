using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0101_0150
{
    [TestClass]
    public class _126_WordLadderIIUnitTest
    {
        _126_WordLadderIIAlg alg = new _126_WordLadderIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            string beginWord = "hit";
            string endWord = "cog";
            string[] wordList = ["hot", "dot", "dog", "lot", "log", "cog"];
            var res = alg.FindLadders(beginWord, endWord, wordList);
            string[][] exp = [["hit", "hot", "dot", "dog", "cog"], ["hit", "hot", "lot", "log", "cog"]];
            bool bl = Utils.IsSameList(res, exp);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            string beginWord = "hit";
            string endWord = "cog";
            string[] wordList = ["hot", "dot", "dog", "lot", "log"];
            var res = alg.FindLadders(beginWord, endWord, wordList);
            string[][] exp = [];
            bool bl = Utils.IsSameList(res, exp);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            string beginWord = "hot";
            string endWord = "dog";
            string[] wordList = ["hot", "dog", "dot"];
            var res = alg.FindLadders(beginWord, endWord, wordList);
            string[][] exp = [["hot", "dot", "dog"]];
            bool bl = Utils.IsSameList(res, exp);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase04()
        {
            string beginWord = "hot";
            string endWord = "dog";
            string[] wordList = ["hot", "cog", "dog", "tot", "hog", "hop", "pot", "dot"];
            var res = alg.FindLadders(beginWord, endWord, wordList);
            string[][] exp = [["hot", "dot", "dog"], ["hot", "hog", "dog"]];
            bool bl = Utils.IsSameList(res, exp);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase05()
        {
            string beginWord = "red";
            string endWord = "tax";
            string[] wordList = ["ted", "tex", "red", "tax", "tad", "den", "rex", "pee"];
            var res = alg.FindLadders(beginWord, endWord, wordList);
            string[][] exp = 
                [["red", "ted", "tad", "tax"], 
                ["red", "ted", "tex", "tax"], 
                ["red", "rex", "tex", "tax"]];
            bool bl = Utils.IsSameList(res, exp);
            Assert.IsTrue(bl);
        }
    }
}
