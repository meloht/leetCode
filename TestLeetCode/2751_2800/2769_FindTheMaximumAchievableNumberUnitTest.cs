using leetCode._2751_2800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2751_2800
{
    [TestClass]
    public class _2769_FindTheMaximumAchievableNumberUnitTest
    {
        _2769_FindTheMaximumAchievableNumberAlg alg = new _2769_FindTheMaximumAchievableNumberAlg();

        [TestMethod]
        public void TestCase01()
        {
            int num = 4, t = 1;
            int exp = 6;
            int res = alg.TheMaximumAchievableX(num, t);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int num = 3, t = 2;
            int exp = 7;
            int res = alg.TheMaximumAchievableX(num, t);
            Assert.AreEqual(exp, res);
        }


    }
}
