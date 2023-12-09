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
           
            string str2 = "1111";
            var res = alg.NumDecodings(str);
            //Assert.AreEqual(5, res);
            Assert.AreEqual(1836311903, res);

        }
        [TestMethod]
        public void TestCase09()
        {
            string str = "10";
            var res = alg.NumDecodings(str);

            Assert.AreEqual(1, res);
        }
        [TestMethod]
        public void TestCase10()
        {
            string str = "27";
            var res = alg.NumDecodings(str);

            Assert.AreEqual(1, res);
        }
        [TestMethod]
        public void TestCase11()
        {
            string str = "123123";
            var res = alg.NumDecodings(str);

            Assert.AreEqual(9, res);
        }
        [TestMethod]
        public void TestCase12()
        {
            string str = "110";
            var res = alg.NumDecodings(str);

            Assert.AreEqual(1, res);
        }
        [TestMethod]
        public void TestCase13()
        {
            string str = "230";
            var res = alg.NumDecodings(str);

            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void TestCase14()
        {
            string str = "301";
            var res = alg.NumDecodings(str);

            Assert.AreEqual(0, res);
        }
    }
}
