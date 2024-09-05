using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _491_NonDecreasingSubsequencesTest
    {
        _491_NonDecreasingSubsequencesAlg alg = new _491_NonDecreasingSubsequencesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [4, 6, 7, 7];
            IList<IList<int>> exp = [[4, 6], [4, 6, 7], [4, 6, 7, 7], [4, 7], [4, 7, 7], [6, 7], [6, 7, 7], [7, 7]];

            IList<IList<int>> res = alg.FindSubsequences(nums);
            Assert.IsTrue(Utils.IsSame(exp,res));

        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [4, 4, 3, 2, 1];
            IList<IList<int>> exp = [[4, 4]];

            IList<IList<int>> res = alg.FindSubsequences(nums);
            Assert.IsTrue(Utils.IsSame(exp, res));

        }
    }
}
