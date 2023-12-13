using leetCode._101_150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._101_150
{
    [TestClass]
    public class _104_MaximumDepthOfBinaryTreeUnitTest
    {
        _104_MaximumDepthOfBinaryTreeAlg alg = new _104_MaximumDepthOfBinaryTreeAlg();


        [TestMethod]
        public void TestCase01()
        {
            int?[] root = { 3, 9, 20, null, null, 15, 7 };
            var tree = Utils.BuildTree(root);
            var res = alg.MaxDepth(tree);
            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = { 1, null, 2 };
            var tree = Utils.BuildTree(root);
            var res = alg.MaxDepth(tree);
            Assert.AreEqual(2, res);
        }
    }
}
