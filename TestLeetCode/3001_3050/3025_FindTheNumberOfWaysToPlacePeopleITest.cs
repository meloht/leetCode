using leetCode._3001_3050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3001_3050
{
    [TestClass]
    public class _3025_FindTheNumberOfWaysToPlacePeopleITest
    {
        _3025_FindTheNumberOfWaysToPlacePeopleIAlg alg = new _3025_FindTheNumberOfWaysToPlacePeopleIAlg();

        [TestMethod]
        public void Test01()
        {
            int[][] points = [[1, 1], [2, 2], [3, 3]];
            int exp = 0;
            int res = alg.NumberOfPairs(points);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test02()
        {
            int[][] points = [[6, 2], [4, 4], [2, 6]];
            int exp = 2;
            int res = alg.NumberOfPairs(points);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test03()
        {
            int[][] points = [[3, 1], [1, 3], [1, 1]];
            int exp = 2;
            int res = alg.NumberOfPairs(points);
            Assert.AreEqual(exp, res);
        }
    }
}
