using leetCode._2101_2150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._2101_2150
{
    [TestClass]
    public class _2140_SolvingQuestionsWithBrainpowerUnitTest
    {
        _2140_SolvingQuestionsWithBrainpowerAlg alg = new _2140_SolvingQuestionsWithBrainpowerAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] questions = [[3, 2], [4, 3], [4, 4], [2, 5]];
            long exp = 5;
            long res = alg.MostPoints(questions);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] questions = [[1, 1], [2, 2], [3, 3], [4, 4], [5, 5]];
            long exp = 7;
            long res = alg.MostPoints(questions);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] questions = [[10, 1], [10, 1], [10, 1], [10, 1], [10, 1]];
            long exp = 30;
            long res = alg.MostPoints(questions);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[][] questions = [[10, 1], [10, 1], [10, 1], [10, 1]];
            long exp = 20;
            long res = alg.MostPoints(questions);
            Assert.AreEqual(exp, res);
        }

 
    }  
}
