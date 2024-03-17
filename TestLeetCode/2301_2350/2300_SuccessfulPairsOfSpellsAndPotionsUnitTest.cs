using leetCode._2301_2350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2301_2350
{
    [TestClass]
    public class _2300_SuccessfulPairsOfSpellsAndPotionsUnitTest
    {
        _2300_SuccessfulPairsOfSpellsAndPotionsAlg alg = new _2300_SuccessfulPairsOfSpellsAndPotionsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] spells = [5, 1, 3], potions = [1, 2, 3, 4, 5];
            int success = 7;
            int[] exp = [4, 0, 3];
            int[] res = alg.SuccessfulPairs(spells, potions, success);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] spells = [3, 1, 2], potions = [8, 5, 8];
            int success = 16;
            int[] exp = [2, 0, 2];
            int[] res = alg.SuccessfulPairs(spells, potions, success);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
