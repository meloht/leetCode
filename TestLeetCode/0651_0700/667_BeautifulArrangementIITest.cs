using leetCode._0651_0700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0651_0700
{
    [TestClass]
    public class _667_BeautifulArrangementIITest
    {
        _667_BeautifulArrangementIIAlg alg = new _667_BeautifulArrangementIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 3, k = 1;
            int[] exp = [1, 2, 3];
            int[] res = alg.ConstructArray(n, k);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 3, k = 2;
            int[] exp = [1, 3, 2];
            int[] res = alg.ConstructArray(n, k);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
