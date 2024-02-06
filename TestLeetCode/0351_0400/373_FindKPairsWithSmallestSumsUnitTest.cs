using leetCode._0351_0400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0351_0400
{
    [TestClass]
    public class _373_FindKPairsWithSmallestSumsUnitTest
    {
        _373_FindKPairsWithSmallestSumsAlg alg = new _373_FindKPairsWithSmallestSumsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums1 = [1, 7, 11], nums2 = [2, 4, 6];
            int k = 3;
            IList<IList<int>> exp = [[1, 2], [1, 4], [1, 6]];
            IList<IList<int>> res = alg.KSmallestPairs(nums1, nums2, k);
            bool bl = Utils.IsSame(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums1 = [1, 1, 2], nums2 = [1, 2, 3];
            int k = 2;
            IList<IList<int>> exp = [[1, 1], [1, 1]];
            IList<IList<int>> res = alg.KSmallestPairs(nums1, nums2, k);
            bool bl = Utils.IsSame(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums1 = [1, 2], nums2 = [3];
            int k = 3;
            IList<IList<int>> exp = [[1, 3], [2, 3]];
            IList<IList<int>> res = alg.KSmallestPairs(nums1, nums2, k);
            bool bl = Utils.IsSame(exp, res);
            Assert.IsTrue(bl);
        }
    }
}
