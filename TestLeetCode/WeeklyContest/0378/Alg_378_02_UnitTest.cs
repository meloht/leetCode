using leetCode.WeeklyContest._0378;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.WeeklyContest._0378
{
    [TestClass]
    public class Alg_378_02_UnitTest
    {
        Alg_378_02 alg = new Alg_378_02();


        [TestMethod]
        public void TestCase01()
        {
            string s = "aaaa";
            var res = alg.MaximumLength(s);
            Assert.AreEqual(2, res);
        }


        [TestMethod]
        public void TestCase02()
        {
            string s = "abcdef";
            var res = alg.MaximumLength(s);
            Assert.AreEqual(-1, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "abcaba";
            var res = alg.MaximumLength(s);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string s = "aiii";
            var res = alg.MaximumLength(s);
            Assert.AreEqual(1, res);
        }
    }
}
