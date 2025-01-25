using leetCode._2201_2250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2201_2250
{
    [TestClass]
    public class _2239_FindClosestNumberToZeroTest
    {
        _2239_FindClosestNumberToZeroAlg alg=new _2239_FindClosestNumberToZeroAlg();


        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [-4, -2, 1, 4, 8];
            int exp = 1;
            int res = alg.FindClosestNumber(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [2, -1, 1];
            int exp = 1;
            int res = alg.FindClosestNumber(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
