using leetCode._0351_0400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0351_0400
{
    [TestClass]
    public class _386_LexicographicalNumbersUnitTest
    {
        _386_LexicographicalNumbersAlg alg = new _386_LexicographicalNumbersAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 13;
            int[] exp = [1, 10, 11, 12, 13, 2, 3, 4, 5, 6, 7, 8, 9];
            int[] res = alg.LexicalOrder(n).ToArray();

            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 2;
            int[] exp = [1, 2];
            int[] res = alg.LexicalOrder(n).ToArray();

            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
