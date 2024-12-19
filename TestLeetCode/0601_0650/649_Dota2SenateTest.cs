using leetCode._0601_0650;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0601_0650
{
    [TestClass]
    public class _649_Dota2SenateTest
    {
        _649_Dota2SenateAlg alg = new _649_Dota2SenateAlg();

        [TestMethod]
        public void TestCase01()
        {
            string senate = "RD";
            string exp = "Radiant";
            string res = alg.PredictPartyVictory(senate);
            Assert.AreEqual(res, exp);
        }

        [TestMethod]
        public void TestCase02()
        {
            string senate = "RDD";
            string exp = "Dire";
            string res = alg.PredictPartyVictory(senate);
            Assert.AreEqual(res, exp);
        }
    }
}
