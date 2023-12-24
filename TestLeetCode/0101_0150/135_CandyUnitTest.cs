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
            int res=alg.Candy(ratings);
            Assert.AreEqual(5, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] ratings = [1, 2, 2];
            int res = alg.Candy(ratings);
            Assert.AreEqual(4, res);
        }
    }
}
