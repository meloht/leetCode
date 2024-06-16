using leetCode.WeeklyContest._0402;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.WeeklyContest._0402
{
    [TestClass]
    public class Test_01
    {
        Alg_01 alg = new Alg_01();

        [TestMethod]
        public void TestMethod1()
        {
            int[] hours = [12, 12, 30, 24, 24];
            int exp = 2;
            int res = alg.CountCompleteDayPairs(hours);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] hours = [72, 48, 24, 3];
            int exp = 3;
            int res = alg.CountCompleteDayPairs(hours);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestMethod3()
        {

        }

        [TestMethod]
        public void TestMethod4()
        {

        }
    }
}
