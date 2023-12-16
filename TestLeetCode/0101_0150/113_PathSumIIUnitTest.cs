using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0101_0150
{
    [TestClass]
    public class _113_PathSumIIUnitTest
    {
        _113_PathSumIIAlg alg = new _113_PathSumIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [5, 4, 8, 11, null, 13, 4, 7, 2, null, null, 5, 1];
            var tree = Utils.BuildTree(root);
            var num = alg.PathSum(tree, 22);

            IList<IList<int>> exp=new List<IList<int>>();
            exp.Add(new int[] { 5, 4, 11, 2 });
            exp.Add(new int[] { 5, 8, 4, 5 });

            bool bl = Utils.IsSameList(exp, num);

            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [1, 2, 3];
            var tree = Utils.BuildTree(root);
            var num = alg.PathSum(tree, 5);

            IList<IList<int>> exp = new List<IList<int>>();
            bool bl = Utils.IsSameList(exp, num);
            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            int?[] root = [1, 2];
            var tree = Utils.BuildTree(root);
            var num = alg.PathSum(tree, 0);

            IList<IList<int>> exp = new List<IList<int>>();
            bool bl = Utils.IsSameList(exp, num);
            Assert.AreEqual(true, bl);
        }
    }
}
