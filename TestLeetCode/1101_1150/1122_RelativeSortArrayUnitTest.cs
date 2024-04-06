using leetCode._1101_1150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1101_1150
{
    [TestClass]
    public class _1122_RelativeSortArrayUnitTest
    {
        _1122_RelativeSortArrayAlg alg = new _1122_RelativeSortArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] arr1 = [2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19], arr2 = [2, 1, 4, 3, 9, 6];
            int[] exp = [2, 2, 2, 1, 4, 3, 3, 9, 6, 7, 19];
            int[] res = alg.RelativeSortArray(arr1, arr2);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] arr1 = [28, 6, 22, 8, 44, 17], arr2 = [22, 28, 8, 6];
            int[] exp = [22, 28, 8, 6, 17, 44];
            int[] res = alg.RelativeSortArray(arr1, arr2);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
