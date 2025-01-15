using leetCode._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0751_0800
{
    [TestClass]
    public class _764_LargestPlusSignTest
    {
        _764_LargestPlusSignAlg alg = new _764_LargestPlusSignAlg();
        [TestMethod]
        public void TestCase01()
        {
            int n = 5;
            int[][] mines = [[4, 2]];
            int exp = 2;
            int res = alg.OrderOfLargestPlusSign(n, mines);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 1;
            int[][] mines = [[0, 0]];
            int exp = 0;
            int res = alg.OrderOfLargestPlusSign(n, mines);
            Assert.AreEqual(exp, res);
        }
    }
}
