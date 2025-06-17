using leetCode._3401_3450;
using leetCode.WeeklyContest._0401;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3401_3450
{
    [TestClass]
    public class _3405_CountTheNumberOfArraysWithKMatchingAdjacentElementsTest
    {
        _3405_CountTheNumberOfArraysWithKMatchingAdjacentElementsAlg alg = new _3405_CountTheNumberOfArraysWithKMatchingAdjacentElementsAlg(); 
        [TestMethod]
        public void Test01()
        {
            int n = 3, m = 2, k = 1;
            int exp = 4;
            int res = alg.CountGoodArrays(n, m, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test02()
        {
            int n = 4, m = 2, k = 2;
            int exp = 6;
            int res = alg.CountGoodArrays(n, m, k);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void Test03()
        {
            int n = 5, m = 2, k = 0;
            int exp = 2;
            int res = alg.CountGoodArrays(n, m, k);
            Assert.AreEqual(exp, res);
        }

    }
}
