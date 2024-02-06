using leetCode._1651_1700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1651_1700
{
    [TestClass]
    public class _1672_RichestCustomerWealthUnitTest
    {
        _1672_RichestCustomerWealthAlg alg = new _1672_RichestCustomerWealthAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] accounts = [[1, 2, 3], [3, 2, 1]];
            int exp = 6;
            int res = alg.MaximumWealth(accounts);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] accounts = [[1, 5], [7, 3], [3, 5]];
            int exp = 10;
            int res = alg.MaximumWealth(accounts);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] accounts = [[2, 8, 7], [7, 1, 3], [1, 9, 5]];
            int exp = 17;
            int res = alg.MaximumWealth(accounts);
            Assert.AreEqual(exp, res);
        }
    }
}
