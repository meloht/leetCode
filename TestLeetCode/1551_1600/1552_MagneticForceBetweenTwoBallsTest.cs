using leetCode._1551_1600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1551_1600
{
    [TestClass]
    public class _1552_MagneticForceBetweenTwoBallsTest
    {
        _1552_MagneticForceBetweenTwoBallsAlg alg = new _1552_MagneticForceBetweenTwoBallsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] position = [1, 2, 3, 4, 7];
            int m = 3;
            int exp = 3;
            var res = alg.MaxDistance(position, m);
            Assert.IsTrue(exp == res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] position = [5, 4, 3, 2, 1, 1000000000];
            int m = 2;
            int exp = 999999999;
            var res = alg.MaxDistance(position, m);
            Assert.IsTrue(exp == res);
        }
    }
}
