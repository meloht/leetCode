using leetCode._0501_0550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0501_0550
{
    [TestClass]
    public class _503_NextGreaterElementIITest
    {
        _503_NextGreaterElementIIAlg alg = new _503_NextGreaterElementIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 1];
            int[] exp = [2, -1, 2];
            int[] res = alg.NextGreaterElements(nums);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 3, 4, 3];
            int[] exp = [2, 3, 4, -1, 4];
            int[] res = alg.NextGreaterElements(nums);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
