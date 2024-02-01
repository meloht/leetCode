using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0051_0100
{
    [TestClass]
    public class _64_MinimumPathSumUnitTest
    {
        _64_MinimumPathSumAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _64_MinimumPathSumAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            var arr = new int[][] { [1, 3, 1], [1, 5, 1], [4, 2, 1] };
            var res = alg.MinPathSum(arr);
            Assert.AreEqual(7, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            var arr = new int[][] { [1, 2, 3], [4, 5, 6] };
            var res = alg.MinPathSum(arr);
            Assert.AreEqual(12, res);
        }

    }
}
