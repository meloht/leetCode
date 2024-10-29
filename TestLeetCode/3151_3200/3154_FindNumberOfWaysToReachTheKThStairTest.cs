using leetCode._3151_4000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3151_4000
{
    [TestClass]
    public class _3154_FindNumberOfWaysToReachTheKThStairTest
    {
        _3154_FindNumberOfWaysToReachTheKThStairAlg alg = new _3154_FindNumberOfWaysToReachTheKThStairAlg();

        [TestMethod]
        public void TestCase01()
        {
            int k = 0;
            int exp = 2;
            int res = alg.WaysToReachStair(k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int k = 1;
            int exp = 4;
            int res = alg.WaysToReachStair(k);
            Assert.AreEqual(exp, res);
        }
    }
}
