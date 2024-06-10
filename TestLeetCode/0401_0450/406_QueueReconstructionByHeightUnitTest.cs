using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _406_QueueReconstructionByHeightUnitTest
    {
        _406_QueueReconstructionByHeightAlg alg = new _406_QueueReconstructionByHeightAlg();

        [TestMethod]
        public void Test1()
        {
            int[][] people = [[7, 0], [4, 4], [7, 1], [5, 0], [6, 1], [5, 2]];
            int[][] exp = [[5, 0], [7, 0], [5, 2], [6, 1], [4, 4], [7, 1]];
            int[][] res = alg.ReconstructQueue(people);
            bool bl = Utils.IsSameList(res, exp);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void Test2()
        {
            int[][] people = [[6, 0], [5, 0], [4, 0], [3, 2], [2, 2], [1, 4]];
            int[][] exp = [[4, 0], [5, 0], [2, 2], [3, 2], [1, 4], [6, 0]];
            int[][] res = alg.ReconstructQueue(people);
            bool bl = Utils.IsSameList(res, exp);
            Assert.IsTrue(bl);
        }
    }
}
