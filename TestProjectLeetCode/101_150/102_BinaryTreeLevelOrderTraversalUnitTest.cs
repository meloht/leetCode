using leetCode._101_150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._101_150
{
    [TestClass]
    public class _102_BinaryTreeLevelOrderTraversalUnitTest
    {
        _102_BinaryTreeLevelOrderTraversalAlg alg = new _102_BinaryTreeLevelOrderTraversalAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = { 1, 2, 2, 3, 4, 4, 3 };
            List<IList<int>> exp = new List<IList<int>>();
            exp.Add(new int[] { 3 });
            exp.Add(new int[] { 9, 20 });
            exp.Add(new int[] { 15, 7 });

            var tree = Utils.BuildTree(root);
            var res = alg.LevelOrder(tree);

            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);

        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = { 1 };
            List<IList<int>> exp = new List<IList<int>>();
            exp.Add(new int[] { 1 });

            var tree = Utils.BuildTree(root);
            var res = alg.LevelOrder(tree);

            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);

        }

        [TestMethod]
        public void TestCase03()
        {
            int?[] root = { };
            List<IList<int>> exp = new List<IList<int>>();
            exp.Add(new int[] { });

            var tree = Utils.BuildTree(root);
            var res = alg.LevelOrder(tree);

            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);

        }
    }
}
