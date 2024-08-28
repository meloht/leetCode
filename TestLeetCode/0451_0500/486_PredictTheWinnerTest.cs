using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _486_PredictTheWinnerTest
    {
        _486_PredictTheWinnerAlg alg = new _486_PredictTheWinnerAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 5, 2];
            bool exp = false;
            bool res = alg.PredictTheWinner(nums);
            Assert.AreEqual(res, exp);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 5, 233, 7];
            bool exp = true;
            bool res = alg.PredictTheWinner(nums);
            Assert.AreEqual(res, exp);
        }
    }
}
