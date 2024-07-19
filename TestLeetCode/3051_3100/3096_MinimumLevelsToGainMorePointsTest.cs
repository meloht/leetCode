using leetCode._3051_3100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3051_3100
{
    [TestClass]
    public class _3096_MinimumLevelsToGainMorePointsTest
    {
        _3096_MinimumLevelsToGainMorePointsAlg alg = new _3096_MinimumLevelsToGainMorePointsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] possible = [1, 0, 1, 0];
            int exp = 1;
            int res = alg.MinimumLevels(possible);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] possible = [1, 1, 1, 1, 1];
            int exp = 3;
            int res = alg.MinimumLevels(possible);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] possible = [0, 0];
            int exp = -1;
            int res = alg.MinimumLevels(possible);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            int[] possible = [1, 1];
            int exp = -1;
            int res = alg.MinimumLevels(possible);
            Assert.AreEqual(exp, res);
        }
    }
}
