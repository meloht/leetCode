using leetCode._0651_0700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0651_0700
{
    [TestClass]
    public class _658_FindKClosestElementsUnitTest
    {
        _658_FindKClosestElementsAlg alg = new _658_FindKClosestElementsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] arr = [1, 2, 3, 4, 5];
            int k = 4, x = 3;
            int[] exp = [1, 2, 3, 4];
            int[] res = alg.FindClosestElements(arr, k, x).ToArray();
            
            Assert.IsTrue(exp.SequenceEqual(res));

        }


        [TestMethod]
        public void TestCase02()
        {
            int[] arr = [1, 2, 3, 4, 5];
            int k = 4, x = -1;
            int[] exp = [1, 2, 3, 4];
            int[] res = alg.FindClosestElements(arr, k, x).ToArray();

            Assert.IsTrue(exp.SequenceEqual(res));

        }
    }
}
