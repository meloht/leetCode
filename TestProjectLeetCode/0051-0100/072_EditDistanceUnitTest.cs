using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._51_100
{
    [TestClass]
    public class _72_EditDistanceUnitTest
    {
        _72_EditDistanceAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _72_EditDistanceAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            var res = alg.MinDistance("horse", "ros");

            var exp = 3;
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            var res = alg.MinDistance("intention", "execution");
        
            var exp = 5;
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase03()
        {
            var res = alg.MinDistance("", "a");

            var exp = 1;
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            var res = alg.MinDistance("a", "ab");

            var exp = 1;
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            var res = alg.MinDistance("a", "b");

            var exp = 1;
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase06()
        {
            var res = alg.MinDistance("ab", "bc");

            var exp = 2;
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase07()
        {
            var res = alg.MinDistance("prosperity", "properties");

            var exp = 4;
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase08()
        {
            var res = alg.MinDistance("pneumonoultramicroscopicsilicovolcanoconiosis", "stereomicroscopically");

            var exp = 30;
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase09()
        {
            var res = alg.MinDistance("pneumono", "stereo");

            var exp = 6;
            Assert.AreEqual(exp, res);
        }

    }
}
