using leetCode._1501_1550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1501_1550
{
    [TestClass]
    public class _1535_FindTheWinnerOfAnArrayGameUnitTest
    {
        _1535_FindTheWinnerOfAnArrayGameAlg alg = new _1535_FindTheWinnerOfAnArrayGameAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] arr = [2, 1, 3, 5, 4, 6, 7];
            int k = 2;
            int exp = 5;
            int res = alg.GetWinner(arr, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] arr = [3, 2, 1];
            int k = 10;
            int exp = 3;
            int res = alg.GetWinner(arr, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] arr = [1, 9, 8, 2, 3, 7, 6, 4, 5];
            int k = 7;
            int exp = 9;
            int res = alg.GetWinner(arr, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] arr = [1, 11, 22, 33, 44, 55, 66, 77, 88, 99];
            int k = 1000000000;
            int exp = 99;
            int res = alg.GetWinner(arr, k);
            Assert.AreEqual(exp, res);
        }
    }
}
