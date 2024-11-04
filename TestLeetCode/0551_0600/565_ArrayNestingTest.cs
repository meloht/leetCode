using leetCode._0551_0600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0551_0600
{
    [TestClass]
    public class _565_ArrayNestingTest
    {
        _565_ArrayNestingAlg alg = new _565_ArrayNestingAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] A = [5, 4, 0, 3, 1, 6, 2];
            int exp = 4;
            int res = alg.ArrayNesting(A);
            Assert.AreEqual(exp, res);
        }

    }
}
