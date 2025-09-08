using leetCode._1301_1350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1301_1350
{
    [TestClass]
    public class _1317_ConvertIntegerToTheSumOfRwoNoZeroIntegersTest
    {
        _1317_ConvertIntegerToTheSumOfRwoNoZeroIntegersAlg alg = new _1317_ConvertIntegerToTheSumOfRwoNoZeroIntegersAlg();

        [TestMethod]
        public void Test01()
        {
            int n = 2;
            int[] exp = [1, 1];
            int[] res = alg.GetNoZeroIntegers(n);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void Test02()
        {
            int n = 11;
            int[] exp = [2, 9];
            int[] res = alg.GetNoZeroIntegers(n);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void Test03()
        {
            int n = 10000;
            int[] exp = [1, 9999];
            int[] res = alg.GetNoZeroIntegers(n);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void Test04()
        {
            int n = 69;
            int[] exp = [1, 68];
            int[] res = alg.GetNoZeroIntegers(n);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void Test05()
        {
            int n = 1010;
            int[] exp = [11, 999];
            int[] res = alg.GetNoZeroIntegers(n);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
