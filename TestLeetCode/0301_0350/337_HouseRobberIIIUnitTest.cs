using leetCode._0301_0350;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0301_0350
{
    [TestClass]
    public class _337_HouseRobberIIIUnitTest
    {
        _337_HouseRobberIIIAlg alg = new _337_HouseRobberIIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [3, 2, 3, null, 3, null, 1];
            int exp = 7;
            var tree=TreeNode.BuildTree(root);
            int res = alg.Rob(tree);
            Assert.AreEqual(exp, res);

        }
        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [3, 4, 5, 1, 3, null, 1];
            int exp = 9;
            var tree = TreeNode.BuildTree(root);
            int res = alg.Rob(tree);
            Assert.AreEqual(exp, res);

        }
    }
}
