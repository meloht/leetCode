using leetCode._2601_2650;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2601_2650
{
    [TestClass]
    public class _2616_MinimizeTheMaximumDifferenceOfPairsTest
    {
        _2616_MinimizeTheMaximumDifferenceOfPairsAlg alg = new _2616_MinimizeTheMaximumDifferenceOfPairsAlg();

        [TestMethod]
        public void Test01()
        {
            int[] nums = [10, 1, 2, 7, 1, 3];
            int p = 2;
            int exp = 1;
            int res = alg.MinimizeMax(nums, p);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test02()
        {
            int[] nums = [4, 2, 1, 2];
            int p = 1;
            int exp = 0;
            int res = alg.MinimizeMax(nums, p);
            Assert.AreEqual(exp, res);
        }
    }
}
