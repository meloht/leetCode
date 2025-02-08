using leetCode._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0751_0800
{
    [TestClass]
    public class _791_CustomSortStringTest
    {
        _791_CustomSortStringAlg alg = new _791_CustomSortStringAlg();

        [TestMethod]
        public void TestCase01()
        {
            string S = "cba";
            string T = "abcd";
            string exp = "cbad";
            string res = alg.CustomSortString(S, T);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string S = "cbafg";
            string T = "abcd";
            string exp = "cbad";
            string res = alg.CustomSortString(S, T);
            Assert.AreEqual(exp, res);
        }
    }
}
