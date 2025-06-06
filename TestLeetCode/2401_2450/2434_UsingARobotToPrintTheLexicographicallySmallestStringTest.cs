using leetCode._2401_2450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2401_2450
{
    [TestClass]
    public class _2434_UsingARobotToPrintTheLexicographicallySmallestStringTest
    {
        _2434_UsingARobotToPrintTheLexicographicallySmallestStringAlg alg = new _2434_UsingARobotToPrintTheLexicographicallySmallestStringAlg();


        [TestMethod]
        public void TestCase01()
        {
            string s = "zza";
            string exp = "azz";
            string res = alg.RobotWithString(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "bac";
            string exp = "abc";
            string res = alg.RobotWithString(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "bdda";
            string exp = "addb";
            string res = alg.RobotWithString(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string s = "bydizfve";
            string exp = "bdevfziy";
            string res = alg.RobotWithString(s);
            Assert.AreEqual(exp, res);
        }
    }
}
