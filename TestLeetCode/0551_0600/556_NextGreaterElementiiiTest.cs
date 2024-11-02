using leetCode._0551_0600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0551_0600
{
    [TestClass]
    public class _556_NextGreaterElementiiiTest
    {
        _556_NextGreaterElementiiiAlg alg = new _556_NextGreaterElementiiiAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 12;
            int exp = 21;
            int res = alg.NextGreaterElement(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 21;
            int exp = -1;
            int res = alg.NextGreaterElement(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 1;
            int exp = -1;
            int res = alg.NextGreaterElement(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int n = 230241;
            int exp = 230412;
            int res = alg.NextGreaterElement(n);
            Assert.AreEqual(exp, res);
        }
    }
}
