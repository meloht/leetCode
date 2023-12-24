using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0101_0150
{
    [TestClass]
    public class _135_CandyUnitTest
    {
        _135_CandyAlg alg = new _135_CandyAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] ratings = [1, 0, 2];
            int res = alg.Candy(ratings);
            Assert.AreEqual(5, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] ratings = [1, 2, 2];
            int res = alg.Candy(ratings);
            Assert.AreEqual(4, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] ratings = [3, 2, 1, 0, 0, 2, 4, 3, 2, 1, 0];
            int res = alg.Candy(ratings);
            Assert.AreEqual(28, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            int[] ratings = [3, 2, 1, 0, 2, 4, 3, 2, 1, 0];
            int res = alg.Candy(ratings);
            Assert.AreEqual(27, res);
        }
        [TestMethod]
        public void TestCase05()
        {
            int[] ratings = [3, 2, 1, 0, 2, 4, 3, 2, 1, 0, 0];
            int res = alg.Candy(ratings);
            Assert.AreEqual(28, res);
        }

        [TestMethod]
        public void TestCase06()
        {
            int[] ratings = [1, 3, 2, 2, 1];
            int res = alg.Candy(ratings);
            Assert.AreEqual(7, res);
        }
    }
}
