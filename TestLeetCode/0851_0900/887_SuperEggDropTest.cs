using leetCode._0851_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0851_0900
{
    [TestClass]
    public class _887_SuperEggDropTest
    {
        _887_SuperEggDropAlg alg = new _887_SuperEggDropAlg();

        [TestMethod]
        public void TestCase01()
        {
            int k = 1, n = 2;
            int exp = 2;
            int res = alg.SuperEggDrop(k, n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int k = 2, n = 6;
            int exp = 3;
            int res = alg.SuperEggDrop(k, n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int k = 3, n = 14;
            int exp = 4;
            int res = alg.SuperEggDrop(k, n);
            Assert.AreEqual(exp, res);
        }
    }
}
