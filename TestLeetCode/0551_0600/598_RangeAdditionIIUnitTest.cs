using leetCode._0551_0600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0551_0600
{
    [TestClass]
    public class _598_RangeAdditionIIUnitTest
    {
        _598_RangeAdditionIIAlg alg = new _598_RangeAdditionIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int m = 3, n = 3;
            int[][] ops = [[2, 2], [3, 3]];
            int exp = 4;
            int res = alg.MaxCount(m, n, ops);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int m = 3, n = 3;
            int[][] ops = [[2, 2], [3, 3], [3, 3], [3, 3], [2, 2], [3, 3], [3, 3], [3, 3], [2, 2], [3, 3], [3, 3], [3, 3]];
            int exp = 4;
            int res = alg.MaxCount(m, n, ops);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int m = 3, n = 3;
            int[][] ops = [];
            int exp = 9;
            int res = alg.MaxCount(m, n, ops);
            Assert.AreEqual(exp, res);
        }
    }
}
