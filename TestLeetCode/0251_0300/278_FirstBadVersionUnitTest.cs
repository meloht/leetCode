using leetCode._0251_0300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0251_0300
{
    [TestClass]
    public class _278_FirstBadVersionUnitTest
    {
       

        [TestMethod]
        public void TestCase01()
        {
            int n = 5, bad = 4;
            _278_FirstBadVersionAlg alg = new _278_FirstBadVersionAlg(bad);
            int exp = 4;
            int res = alg.FirstBadVersion(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 1, bad = 1;
            _278_FirstBadVersionAlg alg = new _278_FirstBadVersionAlg(bad);
            int exp = 1;
            int res = alg.FirstBadVersion(n);
            Assert.AreEqual(exp, res);
        }
    }
}
