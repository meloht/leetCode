using leetCode._2201_2250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2201_2250
{
    [TestClass]
    public class _2218_MaximumValueOfKCoinsFromPilesTest
    {
        _2218_MaximumValueOfKCoinsFromPilesAlg alg = new _2218_MaximumValueOfKCoinsFromPilesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] piles = [[1, 100, 3], [7, 8, 9]];
            int k = 2;
            int exp = 101;
            int res = alg.MaxValueOfCoins(piles, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] piles = [[100], [100], [100], [100], [100], [100], [1, 1, 1, 1, 1, 1, 700]];
            int k = 7;
            int exp = 706;
            int res = alg.MaxValueOfCoins(piles, k);
            Assert.AreEqual(exp, res);
        }
    }
}
