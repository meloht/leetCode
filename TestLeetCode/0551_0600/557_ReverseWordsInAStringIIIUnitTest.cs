using leetCode._0551_0600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0551_0600
{
    [TestClass]
    public class _557_ReverseWordsInAStringIIIUnitTest
    {
        _557_ReverseWordsInAStringIIIAlg alg = new _557_ReverseWordsInAStringIIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "Let's take LeetCode contest";
            string exp = "s'teL ekat edoCteeL tsetnoc";
            string res = alg.ReverseWords(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "Mr Ding";
            string exp = "rM gniD";
            string res = alg.ReverseWords(s);
            Assert.AreEqual(exp, res);
        }
    }
}
