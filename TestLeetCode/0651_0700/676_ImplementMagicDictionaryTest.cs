using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._0651_0700._676_ImplementMagicDictionaryAlg;

namespace Test._0651_0700
{
    [TestClass]
    public class _676_ImplementMagicDictionaryTest
    {
        [TestMethod]
        public void TestCase01()
        {
            MagicDictionary magicDictionary = new MagicDictionary();
            magicDictionary.BuildDict(["hello", "leetcode"]);
            bool res = magicDictionary.Search("hello"); // 返回 False
            Assert.IsFalse(res);
            res = magicDictionary.Search("hhllo"); // 将第二个 'h' 替换为 'e' 可以匹配 "hello" ，所以返回 True
            Assert.IsTrue(res);
            res = magicDictionary.Search("hell"); // 返回 False
            Assert.IsFalse(res);
            res = magicDictionary.Search("leetcoded"); // 返回 False
            Assert.IsFalse(res);
        }
    }
}
