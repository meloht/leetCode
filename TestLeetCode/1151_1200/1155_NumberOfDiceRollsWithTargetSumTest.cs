using leetCode._1151_1200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1151_1200
{
    [TestClass]
    public class _1155_NumberOfDiceRollsWithTargetSumTest
    {
        _1155_NumberOfDiceRollsWithTargetSumAlg alg = new _1155_NumberOfDiceRollsWithTargetSumAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 1, k = 6, target = 3;
            int exp = 1;
            int res = alg.NumRollsToTarget(n, k, target);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 2, k = 6, target = 7;
            int exp = 6;
            int res = alg.NumRollsToTarget(n, k, target);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 30, k = 30, target = 500;
            int exp = 222616187;
            int res = alg.NumRollsToTarget(n, k, target);
            Assert.AreEqual(exp, res);
        }
    }
}
