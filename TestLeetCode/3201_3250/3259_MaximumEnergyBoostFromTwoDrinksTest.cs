using leetCode._3201_3250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3201_3250
{
    [TestClass]
    public class _3259_MaximumEnergyBoostFromTwoDrinksTest
    {
        _3259_MaximumEnergyBoostFromTwoDrinksAlg alg = new _3259_MaximumEnergyBoostFromTwoDrinksAlg();
        [TestMethod]
        public void TestCase01()
        {
            int[] energyDrinkA = [1, 3, 1], energyDrinkB = [3, 1, 1];
            long exp = 5;
            long res = alg.MaxEnergyBoost(energyDrinkA,energyDrinkB);
            Assert.AreEqual(exp,res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] energyDrinkA = [4, 1, 1], energyDrinkB = [1, 1, 3];
            long exp = 7;
            long res = alg.MaxEnergyBoost(energyDrinkA, energyDrinkB);
            Assert.AreEqual(exp, res);
        }
    }
}
