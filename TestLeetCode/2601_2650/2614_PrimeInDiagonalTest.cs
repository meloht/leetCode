using leetCode._2601_2650;
using leetCode.WeeklyContest._0401;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2601_2650
{

    [TestClass]
    public class _2614_PrimeInDiagonalTest
    {
        _2614_PrimeInDiagonalAlg alg = new _2614_PrimeInDiagonalAlg();
        [TestMethod]
        public void TestCase01()
        {
            int[][] nums = [[1, 2, 3], [5, 6, 7], [9, 10, 11]];
            int exp = 11;
            int res = alg.DiagonalPrime(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] nums = [[1, 2, 3], [5, 17, 7], [9, 11, 10]];
            int exp = 17;
            int res = alg.DiagonalPrime(nums);
            Assert.AreEqual(exp, res);
        }

    }
}
