using leetCode.WeeklyContest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode.WeeklyContest
{
    [TestClass]
    public class Alg_374_5_UnitTest
    {
        Alg_374 alg;
        [TestInitialize]
        public void Init()
        {
            alg = new Alg_374();
        }

        [TestMethod]
        public void TestCase01()
        {
            string word = "igigee";
            int res = alg.CountCompleteSubstrings(word, 2);
            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string word = "aaabbbccc";
            int res = alg.CountCompleteSubstrings(word, 3);
            Assert.AreEqual(6, res);
        }

        [TestMethod]
        public void TestCase03()
        {

        }
    }
}
