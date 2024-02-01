using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0051_0100
{
    [TestClass]
    public class _85_MaximalRectangleUnitTest
    {
        _85_MaximalRectangleAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _85_MaximalRectangleAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            char[][] arr = { ['1', '0', '1', '0', '0'], ['1', '0', '1', '1', '1'], ['1', '1', '1', '1', '1'], ['1', '0', '0', '1', '0'] };
            int res = alg.MaximalRectangle(arr);
            Assert.AreEqual(6, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            char[][] arr = { ['0'] };
            int res = alg.MaximalRectangle(arr);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            char[][] arr = { ['1'] };
            int res = alg.MaximalRectangle(arr);
            Assert.AreEqual(1, res);
        }
    }
}
