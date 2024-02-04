using leetCode._1501_1550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1501_1550
{
    [TestClass]
    public class _1502_CanMakeArithmeticProgressionFromequenceUnitTest
    {
        _1502_CanMakeArithmeticProgressionFromequenceAlg alg = new _1502_CanMakeArithmeticProgressionFromequenceAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] arr = [3, 5, 1];
            bool exp = true;
            bool res = alg.CanMakeArithmeticProgression(arr);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] arr = [1, 2, 4];
            bool exp = false;
            bool res = alg.CanMakeArithmeticProgression(arr);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] arr = [0, 0, 1];
            bool exp = false;
            bool res = alg.CanMakeArithmeticProgression(arr);
            Assert.AreEqual(exp, res);
        }

    }
}
