using leetCode._0251_0300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0251_0300
{
    [TestClass]
    public class _274_HIndexUnitTest
    {
        _274_HIndexAlg alg = new _274_HIndexAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] citations = [3, 0, 6, 1, 5];
            int exp = 3;
            int res = alg.HIndex(citations);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] citations = [1, 3, 1];
            int exp = 1;
            int res = alg.HIndex(citations);
            Assert.AreEqual(exp, res);
        }
    }
}
