using leetCode._2201_2250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2201_2250
{
    [TestClass]
    public class _2210_CountHillsAndValleysInAnArrayTest
    {
        _2210_CountHillsAndValleysInAnArrayAlg alg = new _2210_CountHillsAndValleysInAnArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [2, 4, 1, 1, 6, 5];
            int exp = 3;
            int res = alg.CountHillValley(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [6, 6, 5, 5, 4, 1];
            int exp = 0;
            int res = alg.CountHillValley(nums);
            Assert.AreEqual(exp, res);
        }

      
    }
}
