using leetCode._2251_2300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2251_2300
{
    [TestClass]
    public class _2288_ApplyDiscountToPricesTest
    {
        _2288_ApplyDiscountToPricesAlg alg = new _2288_ApplyDiscountToPricesAlg();

        [TestMethod]
        public void TestCase01()
        {
            string sentence = "there are $1 $2 and 5$ candies in the shop";
            int discount = 50;
            string exp= "there are $0.50 $1.00 and 5$ candies in the shop";
            string res = alg.DiscountPrices(sentence, discount);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string sentence = "1 2 $3 4 $5 $6 7 8$ $9 $10$";
            int discount = 100;
            string exp = "1 2 $0.00 4 $0.00 $0.00 7 8$ $0.00 $10$";
            string res = alg.DiscountPrices(sentence, discount);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string sentence = "ka3caz4837h6ada4 r1 $602";
            int discount = 9;
            string exp = "ka3caz4837h6ada4 r1 $547.82";
            string res = alg.DiscountPrices(sentence, discount);
            Assert.AreEqual(exp, res);
        }
    }
}
