using leetCode._0701_0750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0701_0750
{
    [TestClass]
    public class _739_DailyTemperaturesUnitTest
    {
        _739_DailyTemperaturesAlg alg = new _739_DailyTemperaturesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] temperatures = [73, 74, 75, 71, 69, 72, 76, 73];
            int[] exp = [1, 1, 4, 2, 1, 1, 0, 0];
            int[] res = alg.DailyTemperatures(temperatures);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] temperatures = [30, 40, 50, 60];
            int[] exp = [1, 1, 1, 0];
            int[] res = alg.DailyTemperatures(temperatures);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] temperatures = [30, 60, 90];
            int[] exp = [1, 1, 0];
            int[] res = alg.DailyTemperatures(temperatures);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
