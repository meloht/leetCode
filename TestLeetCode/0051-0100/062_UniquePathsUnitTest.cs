using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0051_0100
{
    [TestClass]
    public class _62_UniquePathsUnitTest
    {
        _62_UniquePathsAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _62_UniquePathsAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            var res = alg.UniquePaths(3, 7);
            Assert.AreEqual(28, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            var res = alg.UniquePaths(3, 2);
            Assert.AreEqual(3, res);
        }
        [TestMethod]
        public void TestCase03()
        {
            var res = alg.UniquePaths(2, 2);
            Assert.AreEqual(2, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            var res = alg.UniquePaths(2, 6);
            Assert.AreEqual(6, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            var res = alg.UniquePaths(3, 3);
            Assert.AreEqual(6, res);
        }
        [TestMethod]
        public void TestCase06()
        {
            var res = alg.UniquePaths(3, 4);
            Assert.AreEqual(10, res);
        }
        [TestMethod]
        public void TestCase07()
        {
            var res = alg.UniquePaths(3, 5);
            Assert.AreEqual(15, res);
        }

        [TestMethod]
        public void TestCase08()
        {
            var res = alg.UniquePaths(3, 6);
            Assert.AreEqual(21, res);
        }

        [TestMethod]
        public void TestCase09()
        {
            var res = alg.UniquePaths(3, 1);
            Assert.AreEqual(1, res);
        }
        [TestMethod]
        public void TestCase10()
        {
            var res = alg.UniquePaths(4, 2);
            Assert.AreEqual(4, res);
        }
        [TestMethod]
        public void TestCase11()
        {
            var res = alg.UniquePaths(5, 2);
            Assert.AreEqual(5, res);
        }

        [TestMethod]
        public void TestCase12()
        {
            var res = alg.UniquePaths(23, 12);
           
        }
    }
}
