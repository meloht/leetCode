using leetCode._3101_3150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3101_3150
{
    [TestClass]
    public class _3145_FindProductsOfElementsOfBigArrayTest
    {
        _3145_FindProductsOfElementsOfBigArrayAlg alg = new _3145_FindProductsOfElementsOfBigArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            long[][] queries = [[1, 3, 7]];
            int[] exp = [4];
            int[] res = alg.FindProductsOfElements(queries);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            long[][] queries = [[2, 5, 3], [7, 7, 4]];
            int[] exp = [2, 2];
            int[] res = alg.FindProductsOfElements(queries);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

    }
}
