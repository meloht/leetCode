using leetCode._0601_0650;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0601_0650
{
    [TestClass]
    public class _629_KInversePairsArrayTest
    {
        _629_KInversePairsArrayAlg alg = new _629_KInversePairsArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 3, k = 0;
            int exp = 1;
            int res = alg.KInversePairs(n, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 3, k = 1;
            int exp = 2;
            int res = alg.KInversePairs(n, k);
            Assert.AreEqual(exp, res);
        }
    }
}
