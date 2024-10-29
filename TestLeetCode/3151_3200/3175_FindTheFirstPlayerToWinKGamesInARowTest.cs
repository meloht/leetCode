using leetCode._3151_4000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3151_4000
{
    [TestClass]
    public class _3175_FindTheFirstPlayerToWinKGamesInARowTest
    {
        _3175_FindTheFirstPlayerToWinKGamesInARowAlg alg = new _3175_FindTheFirstPlayerToWinKGamesInARowAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] skills = [4, 2, 6, 3, 9]; 
            int k = 2;
            int exp = 2;
            int res = alg.FindWinningPlayer(skills, 2);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            int[] skills = [2, 5, 4];
            int k = 3;
            int exp = 1;
            int res = alg.FindWinningPlayer(skills, 2);
            Assert.AreEqual(exp, res);
        }
    }
}
