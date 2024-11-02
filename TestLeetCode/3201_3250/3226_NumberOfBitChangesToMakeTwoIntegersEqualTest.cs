using leetCode._3201_3250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3201_3250
{
    [TestClass]
    public class _3226_NumberOfBitChangesToMakeTwoIntegersEqualTest
    {
        _3226_NumberOfBitChangesToMakeTwoIntegersEqualAlg alg = new _3226_NumberOfBitChangesToMakeTwoIntegersEqualAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 13, k = 4;
            int exp = 2;
            int res = alg.MinChanges(n, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 21, k = 21;
            int exp = 0;
            int res = alg.MinChanges(n, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 14, k = 13;
            int exp = -1;
            int res = alg.MinChanges(n, k);
            Assert.AreEqual(exp, res);
        }
    }
}
