using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _455_AssignCookiesUnitTest
    {
        _455_AssignCookiesAlg alg = new _455_AssignCookiesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] g = [1, 2, 3], s = [1, 1];
            int exp = 1;
            int res = alg.FindContentChildren(g, s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] g = [1, 2], s = [1, 2, 3];
            int exp = 2;
            int res = alg.FindContentChildren(g, s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] g = [1, 2, 3], s = [3];
            int exp = 1;
            int res = alg.FindContentChildren(g, s);
            Assert.AreEqual(exp, res);
        }

    }
}
