using leetCode._1251_1300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1251_1300
{
    [TestClass]
    public class _1287_ElementAppearingMoreThan25InSortedArrayTest
    {
        _1287_ElementAppearingMoreThan25InSortedArrayAlg alg = new _1287_ElementAppearingMoreThan25InSortedArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] arr = [1, 2, 2, 6, 6, 6, 6, 7, 10];
            int exp = 6;
            var res = alg.FindSpecialInteger(arr);
            Assert.IsTrue(exp == res);
        }

    }
}
