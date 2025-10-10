using leetCode._3101_3150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3101_3150
{
    [TestClass]
    public class _3147_TakingMaximumEnergyFromTheMysticDungeonTest
    {
        _3147_TakingMaximumEnergyFromTheMysticDungeonAlg alg = new _3147_TakingMaximumEnergyFromTheMysticDungeonAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] energy = [5, 2, -10, -5, 1];
            int k = 3;
            int exp = 3;
            int res = alg.MaximumEnergy(energy, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] energy = [-2, -3, -1];
            int k = 2;
            int exp = -1;
            int res = alg.MaximumEnergy(energy, k);
            Assert.AreEqual(exp, res);
        }
    }
}
