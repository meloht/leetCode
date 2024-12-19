using leetCode._3251_3300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3251_3300
{
    [TestClass]
    public class _3285_FindIndicesOfStableMountainsTest
    {
        _3285_FindIndicesOfStableMountainsAlg alg = new _3285_FindIndicesOfStableMountainsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] height = [1, 2, 3, 4, 5];
            int threshold = 2;
            int[] exp = [3, 4];
            int[] res = alg.StableMountains(height, threshold).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] height = [10, 1, 10, 1, 10];
            int threshold = 3;
            int[] exp = [1, 3];
            int[] res = alg.StableMountains(height, threshold).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] height = [10, 1, 10, 1, 10];
            int threshold = 10;
            int[] exp = [];
            int[] res = alg.StableMountains(height, threshold).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
