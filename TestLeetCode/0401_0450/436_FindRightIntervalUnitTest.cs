using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _436_FindRightIntervalUnitTest
    {
        _436_FindRightIntervalAlg alg = new _436_FindRightIntervalAlg();
        [TestMethod]
        public void TestCase01()
        {
            int[][] intervals = [[1, 2]];
            int[] exp = [-1];
            int[] res = alg.FindRightInterval(intervals);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] intervals = [[3, 4], [2, 3], [1, 2]];
            int[] exp = [-1, 0, 1];
            int[] res = alg.FindRightInterval(intervals);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] intervals = [[1, 4], [2, 3], [3, 4]];
            int[] exp = [-1, 2, -1];
            int[] res = alg.FindRightInterval(intervals);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }

   

}
