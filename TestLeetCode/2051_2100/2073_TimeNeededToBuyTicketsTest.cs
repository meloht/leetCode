using leetCode._2051_2100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2051_2100
{
    [TestClass]
    public class _2073_TimeNeededToBuyTicketsTest
    {
        _2073_TimeNeededToBuyTicketsAlg alg = new _2073_TimeNeededToBuyTicketsAlg();


        [TestMethod]
        public void TestCase01()
        {
            int[] tickets = [2, 3, 2];
            int k = 2;
            int exp = 6;
            int res = alg.TimeRequiredToBuy(tickets, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] tickets = [5, 1, 1, 1];
            int k = 0;
            int exp = 8;
            int res = alg.TimeRequiredToBuy(tickets, k);
            Assert.AreEqual(exp, res);
        }
    }
}
