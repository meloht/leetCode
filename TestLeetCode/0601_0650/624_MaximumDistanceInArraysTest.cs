using leetCode._0601_0650;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0601_0650
{
    [TestClass]
    public class _624_MaximumDistanceInArraysTest
    {
        _624_MaximumDistanceInArraysAlg alg = new _624_MaximumDistanceInArraysAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] arr=[[1, 2, 3], [4, 5], [1, 2, 3]];
            int exp = 4;
            int res = alg.MaxDistance(arr);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] arr = [[1], [1]];
            int exp = 0;
            int res = alg.MaxDistance(arr);
            Assert.AreEqual(exp, res);
        }
    }
}
