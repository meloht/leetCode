using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0201_0250
{
    [TestClass]
    public class _211_DesignAddAndSearchWordsDataStructureUnitTest
    {
        [TestMethod]
        public void TestCase01()
        {
            _211_DesignAddAndSearchWordsDataStructureAlg.WordDictionary wordDictionary = 
                new _211_DesignAddAndSearchWordsDataStructureAlg.WordDictionary();

            wordDictionary.AddWord("bad");
            wordDictionary.AddWord("dad");
            wordDictionary.AddWord("mad");
            Assert.IsFalse(wordDictionary.Search("pad")); // 返回 False
            Assert.IsTrue(wordDictionary.Search("bad")); // 返回 True
            Assert.IsTrue(wordDictionary.Search(".ad")); // 返回 True
            Assert.IsTrue(wordDictionary.Search("b..")); // 返回 True
        }


        [TestMethod]
        public void TestCase02()
        {
            _211_DesignAddAndSearchWordsDataStructureAlg.WordDictionary wordDictionary =
                new _211_DesignAddAndSearchWordsDataStructureAlg.WordDictionary();

            wordDictionary.AddWord("at");
            wordDictionary.AddWord("and");
            wordDictionary.AddWord("an");
            wordDictionary.AddWord("add");
            Assert.IsFalse(wordDictionary.Search("a"));
            Assert.IsFalse(wordDictionary.Search(".at"));
            wordDictionary.AddWord("bat");
            Assert.IsTrue(wordDictionary.Search(".at")); 
            Assert.IsTrue(wordDictionary.Search("an.")); 
            Assert.IsFalse(wordDictionary.Search("a.d."));
            Assert.IsFalse(wordDictionary.Search("b."));
            Assert.IsTrue(wordDictionary.Search("a.d"));
            Assert.IsFalse(wordDictionary.Search("."));
        }
    }
}
