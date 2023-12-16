using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._51_100
{
    [TestClass]
    public class _99_RecoverBinarySearchTreeUnitTest
    {
        _99_RecoverBinarySearchTreeAlg alg = new _99_RecoverBinarySearchTreeAlg();


        [TestMethod]
        public void TestCase01()
        {
            int?[] root = { 1, 3, null, null, 2 };
            var tree = Utils.BuildTree(root);
            alg.RecoverTree(tree);
            int?[] exp = { 3, 1, null, null, 2 };
            int?[] res = Utils.GetTreeList(tree);

            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = { 3, 1, 4, null, null, 2 };
            var tree = Utils.BuildTree(root);
            alg.RecoverTree(tree);
            int?[] exp = { 2, 1, 4, null, null, 3 };
            int?[] res = Utils.GetTreeList(tree);

            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }
        [TestMethod]
        public void TestCase03()
        {
            int?[] root = { 2, 3, 1 };
            var tree = Utils.BuildTree(root);
            alg.RecoverTree(tree);
            int?[] exp = { 2, 1, 3 };
            int?[] res = Utils.GetTreeList(tree);

            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase04()
        {
            int?[] root = { 3, null, 2, null, 1 };
            var tree = Utils.BuildTree(root);
            alg.RecoverTree(tree);
            int?[] exp = { 1, null, 2, null, 3 };
            int?[] res = Utils.GetTreeList(tree);

            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }
    }
}
