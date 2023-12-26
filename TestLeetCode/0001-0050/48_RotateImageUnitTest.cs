using leetCode._1_50;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0001_0050
{
    [TestClass]
    public class _48_RotateImageUnitTest
    {
        _48_RotateImageAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _48_RotateImageAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            var matrix = new int[][] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } };
            var res = new int[][] { new[] { 7, 4, 1 }, new[] { 8, 5, 2 }, new[] { 9, 6, 3 } };
            alg.Rotate(matrix);

            bool bl = Utils.IsSameArr(res, matrix);
            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            var matrix = new int[][]
            {
                new[] { 5, 1, 9, 11 },
                new[] { 2, 4, 8, 10 },
                new[] { 13, 3, 6, 7 },
                new[] { 15, 14, 12, 16 }
            };
            var res = new int[][]
            {
                new[] { 15,13,2,5},
                new[] { 14,3,4,1 },
                new[] { 12, 6, 8, 9 } ,
                new[] { 16, 7, 10, 11 }
            };
            alg.Rotate(matrix);

            bool bl = Utils.IsSameArr(res, matrix);
            Assert.AreEqual(true, bl);
        }
    }
}
