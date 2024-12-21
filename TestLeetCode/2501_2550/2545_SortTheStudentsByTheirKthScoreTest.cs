using leetCode._2501_2550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2501_2550
{
    [TestClass]
    public class _2545_SortTheStudentsByTheirKthScoreTest
    {
        _2545_SortTheStudentsByTheirKthScoreAlg alg = new _2545_SortTheStudentsByTheirKthScoreAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] score = [[10, 6, 9, 1], [7, 5, 11, 2], [4, 8, 3, 15]];
            int k = 2;
            int[][] exp = [[7, 5, 11, 2], [10, 6, 9, 1], [4, 8, 3, 15]];
            int[][] res = alg.SortTheStudents(score,k);
            Assert.IsTrue(Utils.IsSameArr(exp,res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] score = [[3, 4], [5, 6]];
            int k = 0;
            int[][] exp = [[5, 6], [3, 4]];
            int[][] res = alg.SortTheStudents(score, k);
            Assert.IsTrue(Utils.IsSameArr(exp, res));
        }
    }
}
