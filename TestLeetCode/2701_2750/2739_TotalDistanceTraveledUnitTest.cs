using leetCode._2701_2750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2701_2750
{
    [TestClass]
    public class _2739_TotalDistanceTraveledUnitTest
    {
        _2739_TotalDistanceTraveledAlg alg = new _2739_TotalDistanceTraveledAlg();

        [TestMethod]
        public void TestCase01()
        {
            int mainTank = 5, additionalTank = 10;
            int exp = 60;
            int res = alg.DistanceTraveled(mainTank, additionalTank);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int mainTank = 1, additionalTank = 2;
            int exp = 10;
            int res = alg.DistanceTraveled(mainTank, additionalTank);
            Assert.AreEqual(exp, res);
        }
    }
}
