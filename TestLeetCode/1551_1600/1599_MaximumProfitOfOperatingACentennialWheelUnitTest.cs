using leetCode._1551_1600;
using leetCode.WeeklyContest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1551_1600
{
    [TestClass]
    public class _1599_MaximumProfitOfOperatingACentennialWheelUnitTest
    {
        _1599_MaximumProfitOfOperatingACentennialWheelAlg alg = new _1599_MaximumProfitOfOperatingACentennialWheelAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] customers = [8, 3];
            int boardingCost = 5;
            int runningCost = 6;

            int exp = 3;
            int res = alg.MinOperationsMaxProfit(customers, boardingCost, runningCost);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] customers = [10, 9, 6];
            int boardingCost = 6;
            int runningCost = 4;

            int exp = 7;
            int res = alg.MinOperationsMaxProfit(customers, boardingCost, runningCost);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase03()
        {
            int[] customers = [3, 4, 0, 5, 1];
            int boardingCost = 1;
            int runningCost = 92;

            int exp = -1;
            int res = alg.MinOperationsMaxProfit(customers, boardingCost, runningCost);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] customers = [10, 10, 6, 4, 7];
            int boardingCost = 3;
            int runningCost = 8;

            int exp = 9;
            int res = alg.MinOperationsMaxProfit(customers, boardingCost, runningCost);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[] customers = [2];
            int boardingCost = 2;
            int runningCost = 4;

            int exp = -1;
            int res = alg.MinOperationsMaxProfit(customers, boardingCost, runningCost);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase06()
        {
            int[] customers = [8, 3, 0, 0];
            int boardingCost = 5;
            int runningCost = 6;

            int exp = 3;
            int res = alg.MinOperationsMaxProfit(customers, boardingCost, runningCost);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase07()
        {
            int[] customers = [0, 43, 37, 9, 23, 35, 18, 7, 45, 3, 8, 24, 1, 6, 37, 2, 38, 15, 1, 14, 
                39, 27, 4, 25, 27, 33, 43, 8, 44, 30, 38, 40, 20, 5, 17, 27, 43,
                11, 6, 2, 30, 49, 30, 25, 32, 3, 18, 23, 45, 43, 30, 14, 41, 17, 42, 42, 44, 38, 18,
                26, 32, 48, 37, 5, 37, 21, 2, 9, 48, 48, 40, 45, 25, 30, 49, 41, 
                4, 48, 40, 29, 23, 17, 7, 5, 44, 23, 43, 9, 35, 26, 44, 3, 26, 16, 31, 11, 9, 4, 28, 49,
                43, 39, 9, 39, 37, 7, 6, 7, 16, 1, 30, 2, 4, 
                43, 23, 16, 39, 5, 30, 23, 39, 29, 31, 26, 35, 15, 5, 11, 45, 44, 45, 43, 4, 24, 40, 7,
                36, 10, 10, 18, 6, 20, 13, 11, 20, 3, 32, 49, 34, 41, 13, 11, 3,
                13, 0, 13, 44, 48, 43, 23, 12, 23, 2];
            int boardingCost = 43;
            int runningCost = 54;

            int exp = 993;
            int res = alg.MinOperationsMaxProfit(customers, boardingCost, runningCost);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase08()
        {
            int[] customers = [10, 10, 1, 0, 0];
            int boardingCost = 4;
            int runningCost = 4;

            int exp = 5;
            int res = alg.MinOperationsMaxProfit(customers, boardingCost, runningCost);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase09()
        {
            int[] customers = [5, 0, 0, 0, 0, 30];
            int boardingCost = 5;
            int runningCost = 5;

            int exp = 13;
            int res = alg.MinOperationsMaxProfit(customers, boardingCost, runningCost);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase10()
        {
            int[] customers = [21, 1, 38, 42, 33, 16, 26, 26, 49, 3, 31, 37, 7, 43, 18, 46, 44, 27, 42, 16, 15, 29, 17, 7, 50, 20];
            int boardingCost = 14;
            int runningCost = 82;

            int exp = -1;
            int res = alg.MinOperationsMaxProfit(customers, boardingCost, runningCost);
            Assert.AreEqual(exp, res);
        }
    }
}
