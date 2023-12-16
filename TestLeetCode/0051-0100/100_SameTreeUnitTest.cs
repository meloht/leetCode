using leetCode;
using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._51_100
{
    [TestClass]
    public class _100_SameTreeUnitTest
    {

        _100_SameTreeAlg alg = new _100_SameTreeAlg();


        [TestMethod]
        public void TestCase01()
        {
            int?[] arr = { 1, 2, 3 };
            int?[] arr2 = { 1, 2, 3 };

            TreeNode root1 = Utils.BuildBinaryTree(arr);
            TreeNode root2 = Utils.BuildBinaryTree(arr2);
            bool bl = alg.IsSameTree(root1, root2);

            Assert.IsTrue(bl);
        }
        [TestMethod]
        public void TestCase02()
        {
            int?[] arr = { 1, 2 };
            int?[] arr2 = { 1, null, 2 };

            TreeNode root1 = Utils.BuildBinaryTree(arr);
            TreeNode root2 = Utils.BuildBinaryTree(arr2);
            bool bl = alg.IsSameTree(root1, root2);

            Assert.AreEqual(bl, false);
        }
        [TestMethod]
        public void TestCase03()
        {
            int?[] arr = { 1, 2, 1 };
            int?[] arr2 = { 1, 1, 2 };

            TreeNode root1 = Utils.BuildBinaryTree(arr);
            TreeNode root2 = Utils.BuildBinaryTree(arr2);
            bool bl = alg.IsSameTree(root1, root2);

            Assert.AreEqual(bl, false);
        }

        [TestMethod]
        public void TestCase04()
        {
            int?[] arr = { 1, 1 };
            int?[] arr2 = { 1, null, 2 };

            TreeNode root1 = Utils.BuildBinaryTree(arr);
            TreeNode root2 = Utils.BuildBinaryTree(arr2);
            bool bl = alg.IsSameTree(root1, root2);

            Assert.AreEqual(bl, false);
        }

        [TestMethod]
        public void TestCase05()
        {
            int?[] arr = { 10, 5, 15 };
            int?[] arr2 = { 10, 5, null, null, 15 };

            TreeNode root1 = Utils.BuildBinaryTree(arr);
            TreeNode root2 = Utils.BuildBinaryTree(arr2);
            bool bl = alg.IsSameTree(root1, root2);

            Assert.AreEqual(bl, false);
        }
    }
}
