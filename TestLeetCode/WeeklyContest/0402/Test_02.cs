using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode.WeeklyContest._0402;

namespace Test.WeeklyContest._0402
{
    [TestClass]
    public class Test_02
    {
        Alg_02 alg = new Alg_02();

        [TestMethod]
        public void TestMethod1()
        {
            int[] hours = [12, 12, 30, 24, 24];
            long exp = 2;
            long res = alg.CountCompleteDayPairs(hours);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] hours = [72, 48, 24, 3];
            long exp = 3;
            long res = alg.CountCompleteDayPairs(hours);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] hours = [24, 24, 24];
            long exp = 3;
            long res = alg.CountCompleteDayPairs(hours);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestMethod4()
        {

        }
    }
}
