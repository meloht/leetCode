using leetCode._1751_1800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1751_1800
{
    [TestClass]
    public class _1792_MaximumAveragePassRatioTest
    {
        _1792_MaximumAveragePassRatioAlg alg = new _1792_MaximumAveragePassRatioAlg();

        [TestMethod]
        public void Test01()
        {
            int[][] classes = [[1, 2], [3, 5], [2, 2]];
            int extraStudents = 2;
            double exp = 0.78333;
            double res = alg.MaxAverageRatio(classes, extraStudents);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test02()
        {
            int[][] classes = [[2, 4], [3, 9], [4, 5], [2, 10]];
            int extraStudents = 4;
            double exp = 0.53485;
            double res = alg.MaxAverageRatio(classes, extraStudents);
            Assert.AreEqual(exp, res);
        }
    }
}
