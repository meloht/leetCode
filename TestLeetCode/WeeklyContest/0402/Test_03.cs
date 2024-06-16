using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode.WeeklyContest._0402;

namespace Test.WeeklyContest._0402
{
    [TestClass]
    public class Test_03
    {
        Alg_03 alg = new Alg_03();

        [TestMethod]
        public void TestMethod1()
        {
            int[] power = [1, 1, 3, 4];
            long exp = 6;
            long res = alg.MaximumTotalDamage(power);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] power = [7, 1, 6, 6];
            long exp = 13;
            long res = alg.MaximumTotalDamage(power);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] power = [7, 1, 6, 3];
            long exp = 10;
            long res = alg.MaximumTotalDamage(power);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] power = [5, 9, 2, 10, 2, 7, 10, 9, 3, 8];
            long exp = 31;
            long res = alg.MaximumTotalDamage(power);
            Assert.AreEqual(exp, res);
        }
    }
}
