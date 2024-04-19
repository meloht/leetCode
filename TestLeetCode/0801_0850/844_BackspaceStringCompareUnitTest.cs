using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _844_BackspaceStringCompareUnitTest
    {
        _844_BackspaceStringCompareAlg alg = new _844_BackspaceStringCompareAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "ab#c", t = "ad#c";
            bool exp = true;
            bool res = alg.BackspaceCompare(s, t);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "ab##", t = "c#d#";
            bool exp = true;
            bool res = alg.BackspaceCompare(s, t);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "a#c", t = "b";
            bool exp = false;
            bool res = alg.BackspaceCompare(s, t);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string s = "xywrrmp", t = "xywrrmu#p";
            bool exp = true;
            bool res = alg.BackspaceCompare(s, t);
            Assert.AreEqual(exp, res);
        }
    }
}
