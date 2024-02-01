using leetCode._101_150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0101_0150
{
    [TestClass]
    public class _103_BinaryTreeZigzagLevelOrderTraversalUnitTest
    {
        _103_BinaryTreeZigzagLevelOrderTraversalAlg alg = new _103_BinaryTreeZigzagLevelOrderTraversalAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = { 3, 9, 20, null, null, 15, 7 };
            List<IList<int>> exp = new List<IList<int>>();
            exp.Add(new int[] { 3 });
            exp.Add(new int[] { 20, 9 });
            exp.Add(new int[] { 15, 7 });

            var tree = Utils.BuildTree(root);
            var res = alg.ZigzagLevelOrder(tree);

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
            var res = alg.ZigzagLevelOrder(tree);

            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);
        }


        [TestMethod]
        public void TestCase03()
        {
            int?[] root = { };
            List<IList<int>> exp = new List<IList<int>>();

            var tree = Utils.BuildTree(root);
            var res = alg.ZigzagLevelOrder(tree);

            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);

        }

        [TestMethod]
        public void TestCase04()
        {
            int?[] root = { 1, 2, 3, 4, null, null, 5 };
            List<IList<int>> exp = new List<IList<int>>();
            exp.Add(new int[] { 1 });
            exp.Add(new int[] { 3, 2 });
            exp.Add(new int[] { 4, 5 });

            var tree = Utils.BuildTree(root);
            var res = alg.ZigzagLevelOrder(tree);

            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);
        }
    }
}
