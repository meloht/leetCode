using leetCode._2251_2300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2251_2300
{
    [TestClass]
    public class _2294_PartitionArraySuchThatMaximumDifferenceIsKTest
    {
        _2294_PartitionArraySuchThatMaximumDifferenceIsKAlg alg = new _2294_PartitionArraySuchThatMaximumDifferenceIsKAlg();

        [TestMethod]
        public void Test01()
        {
            int[] nums = [3, 6, 1, 2, 5];
            int k = 2;
            int exp = 2;
            int res=alg.PartitionArray(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test02()
        {
            int[] nums = [1, 2, 3];
            int k = 1;
            int exp = 2;
            int res = alg.PartitionArray(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test03()
        {
            int[] nums = [2, 2, 4, 5];
            int k = 0;
            int exp = 3;
            int res = alg.PartitionArray(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test04()
        {
            int[] nums = [0];
            int k = 0;
            int exp = 1;
            int res = alg.PartitionArray(nums, k);
            Assert.AreEqual(exp, res);
        }
    }
}
