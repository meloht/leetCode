using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0051_0100
{
    [TestClass]
    public class _58_LengthOfLastWordUnitTest
    {
        _58_LengthOfLastWordAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _58_LengthOfLastWordAlg();
        }


        [TestMethod]
        public void TestCase01()
        {
            string s = "Hello World";
            int num=alg.LengthOfLastWord(s);
            Assert.AreEqual(5, num);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "   fly me   to   the moon  ";
            int num = alg.LengthOfLastWord(s);
            Assert.AreEqual(4, num);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "luffy is still joyboy";
            int num = alg.LengthOfLastWord(s);
            Assert.AreEqual(6, num);
        }
    }
}
