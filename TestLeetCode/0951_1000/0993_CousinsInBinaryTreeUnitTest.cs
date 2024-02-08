using leetCode._0951_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0951_1000
{
    [TestClass]
    public class _0993_CousinsInBinaryTreeUnitTest
    {
        _0993_CousinsInBinaryTreeAlg alg = new _0993_CousinsInBinaryTreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [1, 2, 3, 4];
            int x = 4, y = 3;
            bool exp = false;
            var tree = Utils.BuildTree(root);
            bool res = alg.IsCousins(tree, x, y);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [1, 2, 3, null, 4, null, 5];
            int x = 5, y = 4;
            bool exp = true;
            var tree = Utils.BuildTree(root);
            bool res = alg.IsCousins(tree, x, y);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int?[] root = [1, 2, 3, null, 4];
            int x = 2, y = 3;
            bool exp = false;
            var tree = Utils.BuildTree(root);
            bool res = alg.IsCousins(tree, x, y);
            Assert.AreEqual(exp, res);
        }
    }
}
