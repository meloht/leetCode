using leetCode._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0751_0800
{
    [TestClass]
    public class _753_CrackingTheSafeUnitTest
    {
        _753_CrackingTheSafeAlg alg = new _753_CrackingTheSafeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 1, k = 2;
            string exp = "10";
            string res = alg.CrackSafe(n, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 2, k = 2;
            string exp = "01100";
            string res = alg.CrackSafe(n, k);
            Assert.AreEqual(exp, res);
        }
    }
}
