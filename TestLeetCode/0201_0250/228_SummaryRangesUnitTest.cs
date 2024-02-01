using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0201_0250
{
    [TestClass]
    public class _228_SummaryRangesUnitTest
    {
        _228_SummaryRangesAlg alg = new _228_SummaryRangesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [0, 1, 2, 4, 5, 7];
            string[] exp = ["0->2", "4->5", "7"];
            var res = alg.SummaryRanges(nums);
            bool bl = exp.SequenceEqual(res.ToArray());
            Assert.IsTrue(bl);
        }


        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [0, 2, 3, 4, 6, 8, 9];
            string[] exp = ["0", "2->4", "6", "8->9"];
            var res = alg.SummaryRanges(nums);
            bool bl = exp.SequenceEqual(res.ToArray());
            Assert.IsTrue(bl);
        }
    }
}
