using leetCode.WeeklyContest._400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.WeeklyContest._400
{
    [TestClass]
    public class Alg_400_03_UnitTest
    {
        Alg_400_03 alg = new Alg_400_03();

        [TestMethod]
        public void TestCase01()
        {
            string s = "aaba*";
            string exp = "aab";
            string res = alg.ClearStars(s);
            Assert.AreEqual(exp, res);
                    
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "abc";
            string exp = "abc";
            string res = alg.ClearStars(s);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase03()
        {
            string s = "d*d*";
            string exp = "";
            string res = alg.ClearStars(s);
            Assert.AreEqual(exp, res);
        }
    }
}
