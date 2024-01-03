using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0201_0250
{
    [TestClass]
    public class _208_ImplementTriePrefixTreeUnitTest
    {


        [TestMethod]
        public void TestCase01()
        {
            _208_ImplementTriePrefixTreeAlg.Trie trie = new _208_ImplementTriePrefixTreeAlg.Trie();
            trie.Insert("apple");
            Assert.IsTrue(trie.Search("apple"));   // 返回 True
            Assert.IsFalse(trie.Search("app"));     // 返回 False
            Assert.IsTrue(trie.StartsWith("app")); // 返回 True
            trie.Insert("app");
            Assert.IsTrue(trie.Search("app"));     // 返回 True
        }
    }
}
