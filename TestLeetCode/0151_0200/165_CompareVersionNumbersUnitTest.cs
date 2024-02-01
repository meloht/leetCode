using leetCode._0151_0200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0151_0200
{
    [TestClass]
    public class _165_CompareVersionNumbersUnitTest
    {
        _165_CompareVersionNumbersAlg alg = new _165_CompareVersionNumbersAlg();

        [TestMethod]
        public void TestCase01()
        {
            string version1 = "1.01", version2 = "1.001";
            int res = alg.CompareVersion(version1, version2);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string version1 = "1.0", version2 = "1.0.0";
            int res = alg.CompareVersion(version1, version2);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string version1 = "0.1", version2 = "1.1";
            int res = alg.CompareVersion(version1, version2);
            Assert.AreEqual(-1, res);
        }
    }
}
