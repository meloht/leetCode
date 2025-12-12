using leetCode._3401_3450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3401_3450
{
    [TestClass]
    public class _3433_CountMentionsPerUserTest
    {
        _3433_CountMentionsPerUserAlg alg = new _3433_CountMentionsPerUserAlg();

        [TestMethod]
        public void Test01()
        {
            int numberOfUsers = 2;
            string[][] events = [["MESSAGE", "10", "id1 id0"], ["OFFLINE", "11", "0"], ["MESSAGE", "71", "HERE"]];
            int[] exp = [2, 2];
            int[] res = alg.CountMentions(numberOfUsers,events);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void Test02()
        {
            int numberOfUsers = 2;
            string[][] events = [["MESSAGE", "10", "id1 id0"], ["OFFLINE", "11", "0"], ["MESSAGE", "12", "ALL"]];
            int[] exp = [2, 2];
            int[] res = alg.CountMentions(numberOfUsers, events);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void Test03()
        {
            int numberOfUsers = 2;
            string[][] events = [["OFFLINE", "10", "0"], ["MESSAGE", "12", "HERE"]];
            int[] exp = [0, 1];
            int[] res = alg.CountMentions(numberOfUsers, events);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
