using leetCode._3151_3200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3151_3200
{
    [TestClass]
    public class _3184_CountPairsThatFormACompleteDayITest
    {
        _3184_CountPairsThatFormACompleteDayIAlg alg = new _3184_CountPairsThatFormACompleteDayIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] hours = [12, 12, 30, 24, 24];
            int exp = 2;
            int res = alg.CountCompleteDayPairs(hours);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] hours = [72, 48, 24, 3];
            int exp = 3;
            int res = alg.CountCompleteDayPairs(hours);
            Assert.AreEqual(exp, res);
        }
    }
}
