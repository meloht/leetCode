using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0201_0250
{
    [TestClass]
    public class _216_CombinationSumIIIUnitTest
    {
        _216_CombinationSumIIIAlg alg = new _216_CombinationSumIIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            var res = alg.CombinationSum3(3, 7);

            int[][] exp = [[1, 2, 4]];

            bool bl = Utils.IsSame(res, exp);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            var res = alg.CombinationSum3(3, 9);

            int[][] exp = [[1, 2, 6], [1, 3, 5], [2, 3, 4]];

            bool bl = Utils.IsSame(res, exp);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            var res = alg.CombinationSum3(4, 1);

            int[][] exp = [];

            bool bl = Utils.IsSame(res, exp);
            Assert.IsTrue(bl);
        }
    }
}
