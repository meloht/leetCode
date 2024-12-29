using leetCode._1351_1400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1351_1400
{
    [TestClass]
    public class _1366_RankTeamsByVotesTest
    {
        _1366_RankTeamsByVotesAlg alg = new _1366_RankTeamsByVotesAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] votes = ["ABC", "ACB", "ABC", "ACB", "ACB"];
            string exp = "ACB";
            string res = alg.RankTeams(votes);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] votes = ["WXYZ", "XYZW"];
            string exp = "XWYZ";
            string res = alg.RankTeams(votes);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string[] votes = ["ZMNAGUEDSJYLBOPHRQICWFXTVK"];
            string exp = "ZMNAGUEDSJYLBOPHRQICWFXTVK";
            string res = alg.RankTeams(votes);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string[] votes = ["BCA", "CAB", "CBA", "ABC", "ACB", "BAC"];
            string exp = "ABC";
            string res = alg.RankTeams(votes);
            Assert.AreEqual(exp, res);
        }
    }
}
