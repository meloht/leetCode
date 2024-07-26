using leetCode._2701_2750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2701_2750
{
    [TestClass]
    public class _2740_FindTheValueOfThePartitionTest
    {
        _2740_FindTheValueOfThePartitionAlg alg = new _2740_FindTheValueOfThePartitionAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 3, 2, 4];
            int exp = 1;
            int res = alg.FindValueOfPartition(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [100, 1, 10];
            int exp = 9;
            int res = alg.FindValueOfPartition(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
