
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode.BiWeeklyConest.bi_132;

namespace Test.BiWeeklyConest._0132
{
    [TestClass]
    public class Alg_132_02_Test
    {
        Alg_132_02 alg = new Alg_132_02();

        [TestMethod]
        public void TestCase01()
        {
            int[] skills = [4, 2, 6, 3, 9];
            int k = 2;
            int exp = 2;
            int res = alg.FindWinningPlayer(skills, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] skills = [2, 5, 4];
            int k = 3;
            int exp = 1;
            int res = alg.FindWinningPlayer(skills, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] skills = [16, 4, 7, 17];
            int k = 562084119;
            int exp = 3;
            int res = alg.FindWinningPlayer(skills, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] skills = [1, 6, 17];
            int k = 1;
            int exp = 1;
            int res = alg.FindWinningPlayer(skills, k);
            Assert.AreEqual(exp, res);
        }
    }
}
