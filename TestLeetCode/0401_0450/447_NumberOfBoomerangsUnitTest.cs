using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0401_0450
{
    [TestClass]
    public class _447_NumberOfBoomerangsUnitTest
    {
        _447_NumberOfBoomerangsAlg alg = new _447_NumberOfBoomerangsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] points = [[0, 0], [1, 0], [2, 0]];
            int exp = 2;
            int res = alg.NumberOfBoomerangs(points);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] points = [[1, 1], [2, 2], [3, 3]];
            int exp = 2;
            int res = alg.NumberOfBoomerangs(points);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] points = [[1, 1]];
            int exp = 0;
            int res = alg.NumberOfBoomerangs(points);
            Assert.AreEqual(exp, res);
        }
    }
}
