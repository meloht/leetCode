using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._51_100
{
    [TestClass]
    public class _90_SubsetsIIUnitTest
    {
        _90_SubsetsIIAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _90_SubsetsIIAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = { 1, 2, 2 };
            var res = alg.SubsetsWithDup(nums);
            int[][] exp = { [], [1], [1, 2], [1, 2, 2], [2], [2, 2] };
            bool bl = Utils.IsSame(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = { 0 };
            var res = alg.SubsetsWithDup(nums);
            int[][] exp = { [], [0] };
            bool bl = Utils.IsSame(exp, res);
            Assert.IsTrue(bl);
        }
        [TestMethod]
        public void TestCase03()
        {
            int[] nums = { 4, 4, 4, 1, 4 };
            var res = alg.SubsetsWithDup(nums);
            int[][] exp = { [], [1], [1, 4], [1, 4, 4], [1, 4, 4, 4], [1, 4, 4, 4, 4], [4], [4, 4], [4, 4, 4], [4, 4, 4, 4] };
            bool bl = Utils.IsSame(exp, res);
            Assert.IsTrue(bl);
        }
    }
}
