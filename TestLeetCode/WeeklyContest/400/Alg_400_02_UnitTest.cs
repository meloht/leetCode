using leetCode.WeeklyContest._400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.WeeklyContest._400
{
    [TestClass]
    public class Alg_400_02_UnitTest
    {
        Alg_400_02 alg = new Alg_400_02();

        [TestMethod]
        public void TestCase01()
        {
            int days = 10;
            int[][] meetings = [[5, 7], [1, 3], [9, 10]];
            int exp = 2;
            int res = alg.CountDays(days, meetings);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int days = 5;
            int[][] meetings = [[2, 4], [1, 3]];
            int exp = 1;
            int res = alg.CountDays(days, meetings);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase03()
        {
            int days = 6;
            int[][] meetings = [[1, 6]];
            int exp = 0;
            int res = alg.CountDays(days, meetings);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int days = 33;
            int[][] meetings = [[3, 9], [7, 16], [21, 23], [22, 33], [5, 13], [10, 23], [1, 15]];
            int exp = 0;
            int res = alg.CountDays(days, meetings);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int days = 34;
            int[][] meetings = [[15, 34], [5, 18], [9, 20], [1, 4], [6, 30], [6, 28], [25, 30], [23, 24]];
            int exp = 0;
            int res = alg.CountDays(days, meetings);
            Assert.AreEqual(exp, res);
        }

        //[TestMethod]
        //public void TestCase06()
        //{
        //    int days = 1000000000;
        //    List<int[]> ls = new List<int[]>();
          
        //    int[][] meetings = [[15, 34], [5, 18], [9, 20], [1, 4], [6, 30], [6, 28], [25, 30], [23, 24]];
        //    int exp = 0;
        //    int res = alg.CountDays(days, meetings);
        //    Assert.AreEqual(exp, res);
        //}
    }
}
