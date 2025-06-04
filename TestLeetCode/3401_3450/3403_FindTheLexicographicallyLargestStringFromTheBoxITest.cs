using leetCode._3401_3450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3401_3450
{
    [TestClass]
    public class _3403_FindTheLexicographicallyLargestStringFromTheBoxITest
    {
        _3403_FindTheLexicographicallyLargestStringFromTheBoxI alg = new _3403_FindTheLexicographicallyLargestStringFromTheBoxI();


        [TestMethod]
        public void TestCase01()
        {
            string word = "dbca";
            int numFriends = 2;
            string exp = "dbc";
            string res = alg.AnswerString(word, numFriends);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string word = "gggg";
            int numFriends = 4;
            string exp = "g";
            string res = alg.AnswerString(word, numFriends);
            Assert.AreEqual(exp, res);
        }
    }
}
