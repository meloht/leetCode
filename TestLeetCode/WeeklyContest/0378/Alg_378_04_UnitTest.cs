using leetCode.WeeklyContest._0378;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode.WeeklyContest._0378
{
    [TestClass]
    public class Alg_378_04_UnitTest
    {
        Alg_378_04 alg = new Alg_378_04();


        [TestMethod]
        public void TestCase01()
        {
            string s = "abcabc";
            int[][] queries = [[1, 1, 3, 5], [0, 2, 5, 5]];

            bool[] exp = [true, true];
            var res = alg.CanMakePalindromeQueries(s, queries);
            Assert.AreEqual(true, exp.SequenceEqual(res));
        }


        [TestMethod]
        public void TestCase02()
        {
            string s = "abbcdecbba";
            int[][] queries = [[0, 2, 7, 9]];

            bool[] exp = [false];
            var res = alg.CanMakePalindromeQueries(s, queries);
            Assert.AreEqual(true, exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "acbcab";
            int[][] queries = [[1, 2, 4, 5]];

            bool[] exp = [true];
            var res = alg.CanMakePalindromeQueries(s, queries);
            Assert.AreEqual(true, exp.SequenceEqual(res));
        }


        [TestMethod]
        public void TestCase04()
        {
            string s = "a".PadLeft(100000, 'a');
           
            List<int[]> list = new List<int[]>();
            int[] aa = [0, 0, 99999, 99999];
            for (int i = 0; i < 100000; i++)
            {
                list.Add(aa);
            }
           
            var res = alg.CanMakePalindromeQueries(s, list.ToArray());
          //  Assert.AreEqual(true, exp.SequenceEqual(res));
        }

    }
}
