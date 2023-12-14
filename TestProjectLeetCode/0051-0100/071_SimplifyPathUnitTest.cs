using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._51_100
{
    [TestClass]
    public class _71_SimplifyPathUnitTest
    {
        _71_SimplifyPathAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _71_SimplifyPathAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            var res = alg.SimplifyPath("/home/");
            var exp = "/home";
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            var res = alg.SimplifyPath("/../");
            var exp = "/";
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase03()
        {
            var res = alg.SimplifyPath("/home//foo/");
            var exp = "/home/foo";
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            var res = alg.SimplifyPath("/a/./b/../../c/");
            var exp = "/c";
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            var res = alg.SimplifyPath("/a//b////c/d//././/..");
            var exp = "/a/b/c";
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase06()
        {
            var res = alg.SimplifyPath("/.");
            var exp = "/";
            Assert.AreEqual(exp, res);
        }
    }
}
