using leetCode._0501_0550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0501_0550
{
    [TestClass]
    public class _543_DiameterOfBinaryTreeUnitTest
    {
        _543_DiameterOfBinaryTreeAlg alg = new _543_DiameterOfBinaryTreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [1, 2, 3, 4, 5];
            var tree = Utils.BuildTree(root);
            int exp = 3;
            int res = alg.DiameterOfBinaryTree(tree);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [1, 2];
            var tree = Utils.BuildTree(root);
            int exp = 1;
            int res = alg.DiameterOfBinaryTree(tree);
            Assert.AreEqual(exp, res);
        }
    }
}
