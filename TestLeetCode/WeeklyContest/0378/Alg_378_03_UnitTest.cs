using leetCode.WeeklyContest._0378;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.WeeklyContest._0378
{
    [TestClass]
    public class Alg_378_03_UnitTest
    {
        Alg_378_03 alg = new Alg_378_03();

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

        [TestMethod]
        public void TestCase05()
        {
            string s = "fafff";
            var res = alg.MaximumLength(s);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestCase06()
        {
            StringBuilder sb = new StringBuilder();
            int num = 5 * 100000;
            for (int i = 0; i < num; i++)
            {
                sb.Append("a");
            }
            string s = sb.ToString(); ;
            var res = alg.MaximumLength(s);
            Assert.AreEqual(num - 2, res);
        }

        [TestMethod]
        public void TestCase07()
        {
            string s = "abcccccdddd";
            var res = alg.MaximumLength(s);
            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void TestCase08()
        {
            string s = "aada";
            var res = alg.MaximumLength(s);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestCase09()
        {
            string s = "bbc";
            var res = alg.MaximumLength(s);
            Assert.AreEqual(-1, res);
        }

        [TestMethod]
        public void TestCase10()
        {
            string s = "ereerrrererrrererre";
            var res = alg.MaximumLength(s);
            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void TestCase11()
        {
            string s = "iiiiifffffffoooookkkfffffffnnxxxxxx";
            var res = alg.MaximumLength(s);
            Assert.AreEqual(6, res);
        }
    }
}
