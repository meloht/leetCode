using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _826_MostProfitAssigningWorkUnitTest
    {
        _826_MostProfitAssigningWorkAlg alg = new _826_MostProfitAssigningWorkAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] difficulty = [2, 4, 6, 8, 10], profit = [10, 20, 30, 40, 50],
                worker = [4, 5, 6, 7];
            int exp = 100;
            int res=alg.MaxProfitAssignment(difficulty, profit, worker);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] difficulty = [85, 47, 57], profit = [24, 66, 99], worker = [40, 25, 25];
            int exp = 0;
            int res = alg.MaxProfitAssignment(difficulty, profit, worker);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] difficulty = [68, 35, 52, 47, 86], profit = [67, 17, 1, 81, 3], worker = [92, 10, 85, 84, 82];
            int exp = 324;
            int res = alg.MaxProfitAssignment(difficulty, profit, worker);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] 
                difficulty = [23, 30, 35, 35, 43, 46, 47, 81, 83, 98], 
                    profit = [8, 11, 11, 20, 33, 37, 60, 72, 87, 95],
                worker = [95, 46, 47, 97, 11, 35, 99, 56, 41, 92];
            int exp = 553;
            int res = alg.MaxProfitAssignment(difficulty, profit, worker);
            Assert.AreEqual(exp, res);
        }
    }
}
