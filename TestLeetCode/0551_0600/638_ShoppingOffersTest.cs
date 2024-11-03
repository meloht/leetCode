using leetCode._0601_0650;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0551_0600
{
    [TestClass]
    public class _638_ShoppingOffersTest
    {
        _638_ShoppingOffersAlg alg = new _638_ShoppingOffersAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] price = [2, 5];
            int[][] special = [[3, 0, 5], [1, 2, 10]];
            int[] needs = [3, 2];
            int exp = 14;
            int res = alg.ShoppingOffers(price, special, needs);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] price = [2, 3, 4];
            int[][] special = [[1, 1, 0, 4], [2, 2, 1, 9]];
            int[] needs = [1, 2, 1];
            int exp = 11;
            int res = alg.ShoppingOffers(price, special, needs);
            Assert.AreEqual(exp, res);
        }
    }
}
