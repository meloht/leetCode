using leetCode._1201_1250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1201_1250
{
    [TestClass]
    public class _1227_AirplaneSeatAssignmentProbabilityTest
    {
        _1227_AirplaneSeatAssignmentProbabilityAlg alg = new _1227_AirplaneSeatAssignmentProbabilityAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 1;
            double exp = 1;
            double res = alg.NthPersonGetsNthSeat(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 2;
            double exp = 0.5;
            double res = alg.NthPersonGetsNthSeat(n);
            Assert.AreEqual(exp, res);
        }
    }
}
