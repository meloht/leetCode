using leetCode._2201_2250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._2201_2250
{
    [TestClass]
    public class _2236_RootEqualsSumOfChildrenUnitTest
    {
        _2236_RootEqualsSumOfChildrenAlg alg = new _2236_RootEqualsSumOfChildrenAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [10, 4, 6];
            var tree = Utils.BuildTree(root);
            bool exp = true;
            bool res = alg.CheckTree(tree);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [5, 3, 1];
            var tree = Utils.BuildTree(root);
            bool exp = false;
            var res = alg.CheckTree(tree);
            Assert.AreEqual(exp, res);
        }
    }
}
