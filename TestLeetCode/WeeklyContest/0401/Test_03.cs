using leetCode.WeeklyContest._0401;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.WeeklyContest._0401
{
    [TestClass]
    public class Test_03
    {
        Alg_03 alg = new Alg_03();

        [TestMethod]
        public void Test1()
        {
            int[] ewardValues = [1, 1, 3, 3];
            int exp = 4;
            int res = alg.MaxTotalReward(ewardValues);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test2()
        {
            int[] ewardValues = [1, 6, 4, 3, 2];
            int exp = 11;
            int res = alg.MaxTotalReward(ewardValues);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test3()
        {
            int[] ewardValues = [1];
            int exp = 1;
            int res = alg.MaxTotalReward(ewardValues);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test4()
        {
            List<int> ls = new List<int>();
            for (int i = 0; i < 2001; i++)
            {
                ls.Add(i);
            }
            int[] ewardValues = [7, 7, 16, 5, 13];
            int exp = 1;
            int res = alg.MaxTotalReward(ls.ToArray());
            //  Assert.AreEqual(exp, res);
        }
    }
}
