using leetCode._1151_1200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1151_1200
{
    [TestClass]
    public class _1169_InvalidTransactionsTest
    {
        _1169_InvalidTransactionsAlg alg = new _1169_InvalidTransactionsAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] transactions = ["alice,20,800,mtv", "alice,50,100,beijing"];
            string[] exp = ["alice,20,800,mtv", "alice,50,100,beijing"];
            string[] res = alg.InvalidTransactions(transactions).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));

        }

        [TestMethod]
        public void TestCase02()
        {
            string[] transactions = ["alice,20,800,mtv", "alice,50,1200,mtv"];
            string[] exp = ["alice,50,1200,mtv"];
            string[] res = alg.InvalidTransactions(transactions).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));

        }

        [TestMethod]
        public void TestCase03()
        {
            string[] transactions = ["alice,20,800,mtv", "bob,50,1200,mtv"];
            string[] exp = ["bob,50,1200,mtv"];
            string[] res = alg.InvalidTransactions(transactions).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));

        }

        [TestMethod]
        public void TestCase04()
        {
            string[] transactions = ["bob,689,1910,barcelona", "alex,696,122,bangkok", "bob,832,1726,barcelona", "bob,820,596,bangkok", "chalicefy,217,669,barcelona", "bob,175,221,amsterdam"];
            string[] exp = ["bob,689,1910,barcelona", "bob,832,1726,barcelona", "bob,820,596,bangkok"];
            string[] res = alg.InvalidTransactions(transactions).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));

        }
    }
}
