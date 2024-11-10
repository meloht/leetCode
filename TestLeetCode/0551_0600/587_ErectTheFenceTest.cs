using leetCode._0551_0600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0551_0600
{
    [TestClass]
    public class _587_ErectTheFenceTest
    {
        _587_ErectTheFenceAlg alg = new _587_ErectTheFenceAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] points = [[1, 1], [2, 2], [2, 0], [2, 4], [3, 3], [4, 2]];
            int[][] exp = [[1, 1], [2, 0], [3, 3], [2, 4], [4, 2]];
            int[][] res = alg.OuterTrees(points);
            bool bl = Utils.IsSame(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] points = [[1, 2], [2, 2], [4, 2]];
            int[][] exp = [[4, 2], [2, 2], [1, 2]];
            int[][] res = alg.OuterTrees(points);
            bool bl = Utils.IsSame(exp, res);
            Assert.IsTrue(bl);
        }
    }
}
