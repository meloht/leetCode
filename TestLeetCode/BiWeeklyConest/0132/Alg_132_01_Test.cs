
using leetCode.BiWeeklyConest.bi_132;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.BiWeeklyConest._0132
{
    [TestClass]
    public class Alg_132_01_Test
    {
        Alg_132_01 alg = new Alg_132_01();

        [TestMethod]
        public void TestCase01()
        {
            string s = "abc";
            string exp = "abc";
            string res = alg.ClearDigits(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "cb34";
            string exp = "";
            string res = alg.ClearDigits(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {

        }

        [TestMethod]
        public void TestCase04()
        {

        }
    }
}
