using leetCode._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0751_0800
{
    [TestClass]
    public class _796_RotateStringUnitTest
    {
        _796_RotateStringAlg alg = new _796_RotateStringAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "abcde", goal = "cdeab";
            bool exp = true;
            bool res = alg.RotateString(s, goal);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "abcde", goal = "abced";
            bool exp = false;
            bool res = alg.RotateString(s, goal);
            Assert.AreEqual(exp, res);
        }
    }
}
