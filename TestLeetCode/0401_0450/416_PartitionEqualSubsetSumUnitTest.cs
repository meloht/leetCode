using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _416_PartitionEqualSubsetSumUnitTest
    {
        _416_PartitionEqualSubsetSumAlg alg = new _416_PartitionEqualSubsetSumAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 5, 11, 5];
            bool exp = true;
            bool res = alg.CanPartition(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 3, 5];
            bool exp = false;
            bool res = alg.CanPartition(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [2, 2, 1, 1];
            bool exp = true;
            bool res = alg.CanPartition(nums);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [9, 1, 2, 4, 10];
            bool exp = true;
            bool res = alg.CanPartition(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[] nums = [1, 5, 10, 6];
            bool exp = true;
            bool res = alg.CanPartition(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
