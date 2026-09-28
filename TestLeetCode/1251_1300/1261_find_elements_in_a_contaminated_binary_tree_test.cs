using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;
using static leetCode._1251_1300._1261_find_elements_in_a_contaminated_binary_tree;

namespace Test._1251_1300
{
    [TestClass]
    public class _1261_find_elements_in_a_contaminated_binary_tree_test
    {
        [TestMethod]
        public void Test01()
        {
            TreeNode node = TreeNode.BuildTree([-1, null, -1]);
            FindElements findElements = new FindElements(node);
            Assert.AreEqual(false, findElements.Find(1)); // return False 
            Assert.AreEqual(true, findElements.Find(2)); // return True 
        }
    }
}
