using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0051_0100
{
    [TestClass]
    public class _54_SpiralMatrixUnitTest
    {
        _54_SpiralMatrixAlg alg;

        [TestInitialize]
        public void Init()
        {
            alg = new _54_SpiralMatrixAlg();
        }

        [TestMethod]
        public void TestCase01()
        {

            int[][] nums = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };
            List<int> list = new List<int>() { 1, 2, 3, 6, 9, 8, 7, 4, 5 };
            var res = alg.SpiralOrder(nums);
            Assert.AreEqual(true, res.SequenceEqual(list));
        }

        [TestMethod]
        public void TestCase02()
        {

            int[][] nums = new int[][]
            {
                new int[] { 1,2,3,4 },
                new int[] { 5,6,7,8 },
                new int[] { 9, 10, 11, 12 }
            };
            List<int> list = new List<int>() { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 };
            var res = alg.SpiralOrder(nums);
            Assert.AreEqual(true, res.SequenceEqual(list));
        }

        [TestMethod]
        public void TestCase03()
        {

            int[][] nums = new int[][]
            {
                new int[] { 1 },

            };
            List<int> list = new List<int>() { 1 };
            var res = alg.SpiralOrder(nums);
            Assert.AreEqual(true, res.SequenceEqual(list));
        }

        [TestMethod]
        public void TestCase04()
        {

            int[][] nums = new int[][]
            {
                new int[] { 2,5,8 },
                 new int[] { 4, 0, -1 }

            };
            List<int> list = new List<int>() { 2, 5, 8, -1, 0, 4 };
            var res = alg.SpiralOrder(nums);
            Assert.AreEqual(true, res.SequenceEqual(list));
        }

    }
}
