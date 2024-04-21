using leetCode._0901_0950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Test._0901_0950
{
    [TestClass]
    public class _925_LongPressedNameUnitTest
    {
        _925_LongPressedNameAlg alg = new _925_LongPressedNameAlg();

        [TestMethod]
        public void TestCase01()
        {
            string name = "alex", typed = "aaleex";
            bool exp = true;
            bool res = alg.IsLongPressedName(name, typed);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string name = "saeed", typed = "ssaaedd";
            bool exp = false;
            bool res = alg.IsLongPressedName(name, typed);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string name = "leelee", typed = "lleeelee";
            bool exp = true;
            bool res = alg.IsLongPressedName(name, typed);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            string name = "alex", typed = "aaleexa";
            bool exp = false;
            bool res = alg.IsLongPressedName(name, typed);
            Assert.AreEqual(exp, res);
        }
    }
}
