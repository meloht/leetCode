using leetCode._2701_2750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2701_2750
{
    [TestClass]
    public class _2708_MaximumStrengthOfAGroupTest
    {
        _2708_MaximumStrengthOfAGroupAlg alg = new _2708_MaximumStrengthOfAGroupAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [3, -1, -5, 2, 5, -9];
            long exp = 1350;
            long res = alg.MaxStrength(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [-4, -5, -4];
            long exp = 20;
            long res = alg.MaxStrength(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {

            int[] nums = [2, 2, 7, 0, -4, 9, 4];
            long exp = 1008;
            long res = alg.MaxStrength(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
