using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0301_0350
{
    [TestClass]
    public class _324_WiggleSortIIUnitTest
    {
        _324_WiggleSortIIAlg alg = new _324_WiggleSortIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 5, 1, 1, 6, 4];
            int[] exp = [1, 6, 1, 5, 1, 4];
            alg.WiggleSort(nums);
            Assert.IsTrue(exp.SequenceEqual(nums));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 3, 2, 2, 3, 1];
            int[] exp = [2, 3, 1, 3, 1, 2];
            alg.WiggleSort(nums);
            Assert.IsTrue(exp.SequenceEqual(nums));
        }
    }
}
