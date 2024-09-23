using leetCode._1051_1100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1051_1100
{
    [TestClass]
    public class _1014_BestSightseeingPairTest
    {
        _1014_BestSightseeingPairAlg alg = new _1014_BestSightseeingPairAlg();

        [TestMethod]
        public void TestCase01() 
        {
            int[] values = [8, 1, 5, 2, 6];
            int exp = 11;
            int res = alg.MaxScoreSightseeingPair(values);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] values = [1, 2];
            int exp = 2;
            int res = alg.MaxScoreSightseeingPair(values);
            Assert.AreEqual(exp, res);
        }
    }
}
