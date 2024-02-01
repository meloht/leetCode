using leetCode._101_150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0101_0150
{
    [TestClass]
    public class _110_BalancedBinaryTreeUnitTest
    {
        _110_BalancedBinaryTreeAlg alg = new _110_BalancedBinaryTreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [3, 9, 20, null, null, 15, 7];
            var tree = Utils.BuildTree(root);

            bool bl = alg.IsBalanced(tree);
            Assert.AreEqual(bl, true);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [1, 2, 2, 3, 3, null, null, 4, 4];
            var tree = Utils.BuildTree(root);

            bool bl = alg.IsBalanced(tree);
            Assert.AreEqual(bl, false);
        }

        [TestMethod]
        public void TestCase03()
        {
            int?[] root = [];
            var tree = Utils.BuildTree(root);

            bool bl = alg.IsBalanced(tree);
            Assert.AreEqual(bl, true);
        }
    }
}
