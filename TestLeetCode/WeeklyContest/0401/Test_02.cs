using leetCode.WeeklyContest._0401;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.WeeklyContest._0401
{
    [TestClass]
    public class Test_02
    {
        Alg_02 alg = new Alg_02();

        [TestMethod]
        public void Test1()
        {
            int n = 4, k = 5;
            int exp = 56;
            int res = alg.ValueAfterKSeconds(n, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test2()
        {
            int n = 5, k = 3;
            int exp = 35;
            int res = alg.ValueAfterKSeconds(n, k);
            Assert.AreEqual(exp, res);
        }


    }
}
