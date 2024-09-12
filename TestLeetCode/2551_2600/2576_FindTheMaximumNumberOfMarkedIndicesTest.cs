using leetCode._2551_2600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2551_2600
{
    [TestClass]
    public class _2576_FindTheMaximumNumberOfMarkedIndicesTest
    {
        _2576_FindTheMaximumNumberOfMarkedIndicesAlg alg = new _2576_FindTheMaximumNumberOfMarkedIndicesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [3, 5, 2, 4];
            int exp = 2;
            int res = alg.MaxNumOfMarkedIndices(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [9, 2, 5, 4];
            int exp = 4;
            int res = alg.MaxNumOfMarkedIndices(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [7, 6, 8];
            int exp = 0;
            int res = alg.MaxNumOfMarkedIndices(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
