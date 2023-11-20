using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._51_100
{
    [TestClass]
    public class _56_MergeIntervalsUnitTest
    {
        _56_MergeIntervalsAlg alg;

        [TestInitialize]
        public void Init()
        {
            alg = new _56_MergeIntervalsAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            var nums = new int[][]
            {
                [1, 3],
                [2, 6],
                [8, 10],
                [15,18]
            };
            var list = new int[][]
            {
               [1, 6],
               [8, 10],
               [15, 18],
            };
            var res = alg.Merge(nums);
            var bl = Utils.IsSameArr(list, res);
            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            var nums = new int[][]
           {
                [ 1, 4 ],
                [4, 5]
           };
            var list = new int[][]
            {
               [1, 5],

            };
            var res = alg.Merge(nums);
            var bl = Utils.IsSameArr(list, res);
            Assert.AreEqual(true, bl);
        }
        [TestMethod]
        public void TestCase03()
        {
            var nums = new int[][]
           {
                [ 1, 3 ]
               
           };
            var list = new int[][]
           {
               [1, 3],

           };
            var res = alg.Merge(nums);
            var bl = Utils.IsSameArr(list, res);
            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase04()
        {
            var nums = new int[][]
           {
                [ 1, 4 ],
                [2, 3]
           };
            var list = new int[][]
            {
               [1, 4],

            };
            var res = alg.Merge(nums);
            var bl = Utils.IsSameArr(list, res);
            Assert.AreEqual(true, bl);
        }
    }
}
