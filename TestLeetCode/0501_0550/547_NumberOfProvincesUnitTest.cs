using leetCode._0501_0550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0501_0550
{
    [TestClass]
    public class _547_NumberOfProvincesUnitTest
    {
        _547_NumberOfProvincesAlg alg = new _547_NumberOfProvincesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] isConnected = [[1, 1, 0], [1, 1, 0], [0, 0, 1]];
            int exp = 2;
            int res = alg.FindCircleNum(isConnected);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] isConnected = [[1, 0, 0], [0, 1, 0], [0, 0, 1]];
            int exp = 3;
            int res = alg.FindCircleNum(isConnected);
            Assert.AreEqual(exp, res);
        }
    }
}
