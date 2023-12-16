using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._51_100
{
    [TestClass]
    public class _57_InsertIntervalUnitTest
    {
        _57_InsertIntervalAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _57_InsertIntervalAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            var nums = new int[][] { [1, 3], [6, 9] };
           
            var list = new int[][] { [1, 5], [6, 9] };
           
            var res = alg.Insert(nums, new int[] { 2, 5 });
            var bl = Utils.IsSameArr(list, res);
            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            var nums = new int[][] { [1, 2], [3, 5], [6, 7], [8, 10], [12, 16] };

            var list = new int[][] { [1, 2], [3, 10], [12, 16] };

            var res = alg.Insert(nums, new int[] { 4, 8 });
            var bl = Utils.IsSameArr(list, res);
            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            var nums = new int[][] { };

            var list = new int[][] { [5, 7] };

            var res = alg.Insert(nums, new int[] { 5, 7 });
            var bl = Utils.IsSameArr(list, res);
            Assert.AreEqual(true, bl);
        }
        [TestMethod]
        public void TestCase04()
        {
            var nums = new int[][] { [1, 5] };

            var list = new int[][] { [1, 5] };

            var res = alg.Insert(nums, new int[] { 2, 3 });
            var bl = Utils.IsSameArr(list, res);
            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase05()
        {
            var nums = new int[][] { [1, 5] };

            var list = new int[][] { [1, 7] };

            var res = alg.Insert(nums, new int[] { 2, 7 });
            var bl = Utils.IsSameArr(list, res);
            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase06()
        {
            var nums = new int[][] { [1, 5] };

            var list = new int[][] { [0, 0], [1, 5] };

            var res = alg.Insert(nums, new int[] { 0, 0 });
            var bl = Utils.IsSameArr(list, res);
            Assert.AreEqual(true, bl);
        }
        [TestMethod]
        public void TestCase07()
        {
            var nums = new int[][] { [2, 5], [6, 7], [8, 9] };

            var list = new int[][] { [0, 1], [2, 5], [6, 7], [8, 9] };

            var res = alg.Insert(nums, new int[] { 0, 1 });
            var bl = Utils.IsSameArr(list, res);
            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase08()
        {
            var nums = new int[][] { [2, 4], [5, 7], [8, 10], [11, 13] };

            var list = new int[][] { [2, 7], [8, 10], [11, 13] };

            var res = alg.Insert(nums, new int[] { 3, 6 });
            var bl = Utils.IsSameArr(list, res);
            Assert.AreEqual(true, bl);
        }

    }
}
