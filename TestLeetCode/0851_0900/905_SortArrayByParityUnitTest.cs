using leetCode._0851_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0851_0900
{
    [TestClass]
    public class _905_SortArrayByParityUnitTest
    {
        _905_SortArrayByParityAlg alg = new _905_SortArrayByParityAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [3, 1, 2, 4];
            int[] exp = [2, 4, 3, 1];
            int[] res = alg.SortArrayByParity(nums);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [0];
            int[] exp = [0];
            int[] res = alg.SortArrayByParity(nums);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
