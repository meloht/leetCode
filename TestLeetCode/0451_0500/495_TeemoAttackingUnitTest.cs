using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _495_TeemoAttackingUnitTest
    {
        _495_TeemoAttackingAlg alg = new _495_TeemoAttackingAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] timeSeries = [1, 4];
            int duration = 2;
            int exp = 4;
            int res = alg.FindPoisonedDuration(timeSeries, duration);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] timeSeries = [1, 2];
            int duration = 2;
            int exp = 3;
            int res = alg.FindPoisonedDuration(timeSeries, duration);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] timeSeries = [1];
            int duration = 100000;
            int exp = 100000;
            int res = alg.FindPoisonedDuration(timeSeries, duration);
            Assert.AreEqual(exp, res);
        }

    }
}
