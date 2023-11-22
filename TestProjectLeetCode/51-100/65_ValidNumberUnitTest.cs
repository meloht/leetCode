using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._51_100
{
    [TestClass]
    public class _65_ValidNumberUnitTest
    {
        _65_ValidNumberAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _65_ValidNumberAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            var res = alg.IsNumber("0");
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            var res = alg.IsNumber("e");
            Assert.AreEqual(false, res);
        }
        [TestMethod]
        public void TestCase03()
        {
            var res = alg.IsNumber(".");
            Assert.AreEqual(false, res);
        }
    }
}
