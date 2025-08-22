using leetCode._1051_1100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1051_1100
{
    [TestClass]
    public class _1073_AddingTwoNegabinaryNumbersTest
    {
        _1073_AddingTwoNegabinaryNumbersAlg alg = new _1073_AddingTwoNegabinaryNumbersAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] arr1 = [1, 1, 1, 1, 1], arr2 = [1, 0, 1];
            int[] exp = [1, 0, 0, 0, 0];
            int[] res = alg.AddNegabinary(arr1, arr2);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] arr1 = [0], arr2 = [0];
            int[] exp = [0];
            int[] res = alg.AddNegabinary(arr1, arr2);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] arr1 = [0], arr2 = [1];
            int[] exp = [1];
            int[] res = alg.AddNegabinary(arr1, arr2);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
