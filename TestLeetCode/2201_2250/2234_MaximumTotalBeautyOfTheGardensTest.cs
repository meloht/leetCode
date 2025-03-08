using leetCode._2201_2250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2201_2250
{
    [TestClass]
    public class _2234_MaximumTotalBeautyOfTheGardensTest
    {
        _2234_MaximumTotalBeautyOfTheGardensAlg alg = new _2234_MaximumTotalBeautyOfTheGardensAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] flowers = [1, 3, 1, 1];
            long newFlowers = 7;
            int target = 6, full = 12, partial = 1;
            long exp = 14;
            long res = alg.MaximumBeauty(flowers, newFlowers, target, full, partial);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] flowers = [2, 4, 5, 3];
            long newFlowers = 10;
            int target = 5, full = 2, partial = 6;
            long exp = 30;
            long res = alg.MaximumBeauty(flowers, newFlowers, target, full, partial);
        }
    }
}
