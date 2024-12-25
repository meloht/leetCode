using leetCode._3201_3250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3201_3250
{
    [TestClass]
    public class _3218_MinimumCostForCuttingCakeITest
    {
        _3218_MinimumCostForCuttingCakeIAlg alg = new _3218_MinimumCostForCuttingCakeIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int m = 3, n = 2;
            int[] horizontalCut = [1, 3], verticalCut = [5];
            int exp = 13;
            int res = alg.MinimumCost(m, n, horizontalCut, verticalCut);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int m = 2, n = 2;
            int[] horizontalCut = [7], verticalCut = [4];
            int exp = 15;
            int res = alg.MinimumCost(m, n, horizontalCut, verticalCut);
            Assert.AreEqual(exp, res);
        }
    }
}
