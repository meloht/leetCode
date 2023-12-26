using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0051_0100
{
    [TestClass]
    public class _63_UniquePathsIIUnitTest
    {
        _63_UniquePathsIIAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _63_UniquePathsIIAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            var arr = new int[][] { [0, 0, 0], [0, 1, 0], [0, 0, 0] };
            var res = alg.UniquePathsWithObstacles(arr);
            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            var arr = new int[][] { [0, 1], [0, 0] };
            var res = alg.UniquePathsWithObstacles(arr);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            var arr = new int[][] { [1, 0] };
            var res = alg.UniquePathsWithObstacles(arr);
            Assert.AreEqual(0, res);
        }
    }
}
