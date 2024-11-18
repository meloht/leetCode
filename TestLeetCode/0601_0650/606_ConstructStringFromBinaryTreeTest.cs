using leetCode._0601_0650;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0601_0650
{
    [TestClass]
    public class _606_ConstructStringFromBinaryTreeTest
    {
        _606_ConstructStringFromBinaryTreeAlg alg = new _606_ConstructStringFromBinaryTreeAlg();


        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [1, 2, 3, 4];
            TreeNode node = TreeNode.BuildTree(root);
            string exp = "1(2(4))(3)";
            string res = alg.Tree2str(node);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [1, 2, 3, null, 4];
            TreeNode node = TreeNode.BuildTree(root);
            string exp = "1(2()(4))(3)";
            string res = alg.Tree2str(node);
            Assert.AreEqual(exp, res);
        }
    }
}
