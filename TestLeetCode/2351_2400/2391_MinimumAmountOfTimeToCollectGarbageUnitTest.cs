using leetCode._2351_2400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2351_2400
{
    [TestClass]
    public class _2391_MinimumAmountOfTimeToCollectGarbageUnitTest
    {
        _2391_MinimumAmountOfTimeToCollectGarbageAlg alg = new _2391_MinimumAmountOfTimeToCollectGarbageAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] garbage = ["G", "P", "GP", "GG"];
            int[] travel = [2, 4, 3];
            int exp = 21;
            int res = alg.GarbageCollection(garbage, travel);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] garbage = ["MMM", "PGM", "GP"];
            int[] travel = [3, 10];
            int exp = 37;
            int res = alg.GarbageCollection(garbage, travel);
            Assert.AreEqual(exp, res);
        }
    }
}
