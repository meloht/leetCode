using leetCode._0151_0200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0151_0200
{
    [TestClass]
    public class _199_BinaryTreeRightSideViewUnitTest
    {
        _199_BinaryTreeRightSideViewAlg alg = new _199_BinaryTreeRightSideViewAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] nums = [1, 2, 3, null, 5, null, 4];
            var tree = Utils.BuildTree(nums);
            var res = alg.RightSideView(tree);
            int[] exp = [1, 3, 4];
            Assert.AreEqual(exp.SequenceEqual(res), true);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] nums = [1, null, 3];
            var tree = Utils.BuildTree(nums);
            var res = alg.RightSideView(tree);
            int[] exp = [1, 3];
            Assert.AreEqual(exp.SequenceEqual(res), true);
        }

        [TestMethod]
        public void TestCase03()
        {
            int?[] nums = [];
            var tree = Utils.BuildTree(nums);
            var res = alg.RightSideView(tree);
            int[] exp = [];
            Assert.AreEqual(exp.SequenceEqual(res), true);
        }


    }
}
