using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._51_100
{
    [TestClass]
    public class _98_ValidateBinarySearchTreeUnitTest
    {
        _98_ValidateBinarySearchTreeAlg alg = new _98_ValidateBinarySearchTreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] arr = { 2, 1, 3 };
            var tree = Utils.BuildBinaryTree(arr);
            var bl= alg.IsValidBST(tree);
            Assert.IsTrue(bl);
        }
        [TestMethod]
        public void TestCase02()
        {
            int?[] arr = { 5, 1, 4, null, null, 3, 6 };
            var tree = Utils.BuildBinaryTree(arr);
            var bl = alg.IsValidBST(tree);
            Assert.IsTrue(bl);
        }
    }
}
