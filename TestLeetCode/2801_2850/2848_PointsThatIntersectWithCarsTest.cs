using leetCode._2801_2850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2801_2850
{
    [TestClass]
    public class _2848_PointsThatIntersectWithCarsTest
    {
        _2848_PointsThatIntersectWithCarsAlg alg = new _2848_PointsThatIntersectWithCarsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] nums = [[3, 6], [1, 5], [4, 7]];
            int exp = 7;
            int res=alg.NumberOfPoints(nums);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] nums = [[1, 3], [5, 8]];
            int exp = 7;
            int res = alg.NumberOfPoints(nums);
            Assert.AreEqual(exp, res);

        }
    }
}
