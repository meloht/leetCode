using leetCode._0251_0300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0251_0300
{
    [TestClass]
    public class _257_BinaryTreePathsUnitTest
    {
        _257_BinaryTreePathsAlg alg = new _257_BinaryTreePathsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [1, 2, 3, null, 5];
            var tree = Utils.BuildTree(root);
            string[] exp = ["1->2->5", "1->3"];
            Array.Sort(exp);
            string[] res = alg.BinaryTreePaths(tree).ToArray();
            Array.Sort(res);
            Assert.IsTrue(exp.SequenceEqual(res));
        }


        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [1];
            var tree = Utils.BuildTree(root);
            string[] exp = ["1"];

            string[] res = alg.BinaryTreePaths(tree).ToArray();
            Array.Sort(exp);
            Array.Sort(res);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
