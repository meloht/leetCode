using leetCode._2801_2850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2801_2850
{
    [TestClass]
    public class _2813_MaximumEleganceOfAKLengthSubsequenceUnitTest
    {
        _2813_MaximumEleganceOfAKLengthSubsequenceAlg alg = new _2813_MaximumEleganceOfAKLengthSubsequenceAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] items = [[3, 2], [5, 1], [10, 1]];
            int k = 2;
            long exp = 17;
            long res = alg.FindMaximumElegance(items, k);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase02()
        {
            int[][] items = [[3, 1], [3, 1], [2, 2], [5, 3]];
            int k = 3;
            long exp = 19;
            long res = alg.FindMaximumElegance(items, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] items = [[1, 1], [2, 1], [3, 1]];
            int k = 3;
            long exp = 7;
            long res = alg.FindMaximumElegance(items, k);
            Assert.AreEqual(exp, res);
        }
    }
}
