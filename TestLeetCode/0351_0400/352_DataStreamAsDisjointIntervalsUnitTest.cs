using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._0351_0400._352_DataStreamAsDisjointIntervalsAlg;

namespace Test._0351_0400
{
    [TestClass]
    public class _352_DataStreamAsDisjointIntervalsUnitTest
    {
        [TestMethod]
        public void TestCase01()
        {
            SummaryRanges summaryRanges = new SummaryRanges();
            summaryRanges.AddNum(1);      // arr = [1]

            int[][] exp1 = [[1, 1]];
            var res1 = summaryRanges.GetIntervals();
            Assert.IsTrue(Utils.IsSameArr(exp1, res1)); // 返回 [[1, 1]]

            summaryRanges.AddNum(3);      // arr = [1, 3]
            int[][] exp2 = [[1, 1], [3, 3]];
            var res2 = summaryRanges.GetIntervals(); // 返回 [[1, 1], [3, 3]]
            Assert.IsTrue(Utils.IsSameArr(exp2, res2));
            summaryRanges.AddNum(7);      // arr = [1, 3, 7]

            int[][] exp3 = [[1, 1], [3, 3], [7, 7]];
            var res3 = summaryRanges.GetIntervals(); // 返回 [[1, 1], [3, 3], [7, 7]]
            Assert.IsTrue(Utils.IsSameArr(exp3, res3));

            summaryRanges.AddNum(2);      // arr = [1, 2, 3, 7]
            int[][] exp4 = [[1, 3], [7, 7]];
            var res4 = summaryRanges.GetIntervals(); // 返回 [[1, 3], [7, 7]]
            Assert.IsTrue(Utils.IsSameArr(exp4, res4));

            summaryRanges.AddNum(6);      // arr = [1, 2, 3, 6, 7]
            summaryRanges.GetIntervals(); // 返回 [[1, 3], [6, 7]]
        }
    }
}
