using leetCode.WeeklyContest._400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.WeeklyContest._400
{
    [TestClass]
    public class Alg_400_01_UnitTest
    {
        Alg_400_01 alg = new Alg_400_01();

        [TestMethod]
        public void TestCase01()
        {
            string s = "EEEEEEE";
            int exp = 7;
            int res = alg.MinimumChairs(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "ELELEEL";
            int exp = 2;
            int res = alg.MinimumChairs(s);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase03()
        {
            string s = "ELEELEELLL";
            int exp = 3;
            int res = alg.MinimumChairs(s);
            Assert.AreEqual(exp, res);
        }
    }
}
