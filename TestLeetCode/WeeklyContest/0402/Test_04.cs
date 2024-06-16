using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode.WeeklyContest._0402;

namespace Test.WeeklyContest._0402
{
    [TestClass]
    public class Test_04
    {
        Alg_04 alg = new Alg_04();

        [TestMethod]
        public void TestMethod1()
        {
            int[] nums = [3, 1, 4, 2, 5];
            int[][] queries = [[2, 3, 4], [1, 0, 4]];
            int[] exp = [0];
            int[] res = alg.CountOfPeaks(nums, queries).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] nums = [4, 1, 4, 2, 1, 5];
            int[][] queries = [[2, 2, 4], [1, 0, 2], [1, 0, 4]];
            int[] exp = [0, 1];
            int[] res = alg.CountOfPeaks(nums, queries).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestMethod3()
        {

        }

        [TestMethod]
        public void TestMethod4()
        {

        }
    }
}
