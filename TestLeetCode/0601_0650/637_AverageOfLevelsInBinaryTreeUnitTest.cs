using leetCode._0601_0650;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0601_0650
{
    [TestClass]
    public class _637_AverageOfLevelsInBinaryTreeUnitTest
    {
        _637_AverageOfLevelsInBinaryTreeAlg alg = new _637_AverageOfLevelsInBinaryTreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [3, 9, 20, null, null, 15, 7];
            double[] exp = [3.00000, 14.50000, 11.00000];
            var tree = Utils.BuildTree(root);
            double[] res = alg.AverageOfLevels(tree).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [3, 9, 20, 15, 7];
            double[] exp = [3.00000, 14.50000, 11.00000];
            var tree = Utils.BuildTree(root);
            double[] res = alg.AverageOfLevels(tree).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
