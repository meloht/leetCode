using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._2251_2300._2296_DesignATextEditorAlg;

namespace Test._2251_2300
{
    [TestClass]
    public class _2296_DesignATextEditorTest
    {
        [TestMethod]
        public void TestCase01()
        {
            TextEditor textEditor = new TextEditor(); // 当前 text 为 "|" 。（'|' 字符表示光标）
            textEditor.AddText("leetcode"); // 当前文本为 "leetcode|" 。
            Assert.AreEqual(4, textEditor.DeleteText(4)); // 返回 4
                                                          // 当前文本为 "leet|" 。
                                                          // 删除了 4 个字符。
            textEditor.AddText("practice"); // 当前文本为 "leetpractice|" 。
            Assert.AreEqual("etpractice", textEditor.CursorRight(3)); // 返回 "etpractice"
                                                                      // 当前文本为 "leetpractice|". 
                                                                      // 光标无法移动到文本以外，所以无法移动。
                                                                      // "etpractice" 是光标左边的 10 个字符。
            Assert.AreEqual("leet", textEditor.CursorLeft(8)); // 返回 "leet"
                                                               // 当前文本为 "leet|practice" 。
                                                               // "leet" 是光标左边的 min(10, 4) = 4 个字符。
            Assert.AreEqual(4, textEditor.DeleteText(10)); // 返回 4
                                                           // 当前文本为 "|practice" 。
                                                           // 只有 4 个字符被删除了。
            Assert.AreEqual("", textEditor.CursorLeft(2)); // 返回 ""
                                                           // 当前文本为 "|practice" 。
                                                           // 光标无法移动到文本以外，所以无法移动。
                                                           // "" 是光标左边的 min(10, 0) = 0 个字符。
            Assert.AreEqual("practi", textEditor.CursorRight(6)); // 返回 "practi"
                                                                  // 当前文本为 "practi|ce" 。
                                                                  // "practi" 是光标左边的 min(10, 6) = 6 个字符。
        }

    }
}
