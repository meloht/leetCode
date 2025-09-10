using leetCode._1701_1750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1701_1750
{
    [TestClass]
    public class _1733_MinimumNumberOfPeopleToTeachTest
    {
        _1733_MinimumNumberOfPeopleToTeachAlg alg = new _1733_MinimumNumberOfPeopleToTeachAlg();

        [TestMethod]
        public void Test01()
        {
            int n = 2;
            int[][] languages = [[1], [2], [1, 2]], friendships = [[1, 2], [1, 3], [2, 3]];
            int exp = 1;
            int res = alg.MinimumTeachings(n, languages, friendships);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test02()
        {
            int n = 3;
            int[][] languages = [[2], [1, 3], [1, 2], [3]], friendships = [[1, 4], [1, 2], [3, 4], [2, 3]];
            int exp = 2;
            int res = alg.MinimumTeachings(n, languages, friendships);
            Assert.AreEqual(exp, res);
        }
    }
}
