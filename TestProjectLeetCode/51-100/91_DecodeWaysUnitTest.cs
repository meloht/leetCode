using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._51_100
{
    [TestClass]
    public class _91_DecodeWaysUnitTest
    {
        _91_DecodeWaysAlg alg = new _91_DecodeWaysAlg();
       
        [TestMethod]
        public void TestCase01()
        {
            string str = "12";
            var res = alg.NumDecodings(str);
           
            Assert.AreEqual(2,res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string str = "226";
            var res = alg.NumDecodings(str);

            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string str = "06";
            var res = alg.NumDecodings(str);

            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string str = "2101";
            var res = alg.NumDecodings(str);

            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            string str = "1201234";
            var res = alg.NumDecodings(str);

            Assert.AreEqual(3, res);
        }
        [TestMethod]
        public void TestCase06()
        {
            string str = "10011";
            var res = alg.NumDecodings(str);

            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestCase07()
        {
            string str = "2611055971756562";
            var res = alg.NumDecodings(str);

            Assert.AreEqual(4, res);
        }

        [TestMethod]
        public void TestCase08()
        {
            string str = "111111111111111111111111111111111111111111111";
            var res = alg.NumDecodings(str);

          
        }
    }
}
