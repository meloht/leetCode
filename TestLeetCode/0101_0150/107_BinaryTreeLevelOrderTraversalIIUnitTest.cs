using leetCode._101_150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0101_0150
{
    [TestClass]
    public class _107_BinaryTreeLevelOrderTraversalIIUnitTest
    {
        _107_BinaryTreeLevelOrderTraversalIIAlg alg = new _107_BinaryTreeLevelOrderTraversalIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = { 3, 9, 20, null, null, 15, 7 };
            List<IList<int>> exp = new List<IList<int>>();
            exp.Add(new int[] { 15, 7 });
            exp.Add(new int[] { 9, 20 });
            exp.Add(new int[] { 3 });
          
            var tree = Utils.BuildTree(root);
            var res = alg.LevelOrderBottom(tree);

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
            var res = alg.LevelOrderBottom(tree);

            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);

        }
        [TestMethod]
        public void TestCase03()
        {
            int?[] root = { };
            List<IList<int>> exp = new List<IList<int>>();

            var tree = Utils.BuildTree(root);
            var res = alg.LevelOrderBottom(tree);

            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);

        }
    }
}
