using leetCode._2951_3000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2951_3000
{
    [TestClass]
    public class _2960_CountTestedDevicesAfterTestOperationsUnitTest
    {
        _2960_CountTestedDevicesAfterTestOperationsAlg alg = new _2960_CountTestedDevicesAfterTestOperationsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] batteryPercentages = [1, 1, 2, 1, 3];
            int exp = 3;
            int res = alg.CountTestedDevices(batteryPercentages);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] batteryPercentages = [0, 1, 2];
            int exp = 2;
            int res = alg.CountTestedDevices(batteryPercentages);
            Assert.AreEqual(exp, res);
        }


    }
}
