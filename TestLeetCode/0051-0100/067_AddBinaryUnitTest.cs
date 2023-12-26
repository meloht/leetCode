using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0051_0100
{
    [TestClass]
    public class _67_AddBinaryUnitTest
    {
        _67_AddBinaryAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _67_AddBinaryAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            var res = alg.AddBinary("11","1");
            Assert.AreEqual("100", res);
        }

        [TestMethod]
        public void TestCase02()
        {
            var res = alg.AddBinary("1010", "1011");
            Assert.AreEqual("10101", res);
        }
    }
}
