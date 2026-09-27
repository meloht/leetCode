using leetCode._1201_1250;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test._1201_1250
{
    [TestClass]
    public class _1253_reconstruct_a_2_row_binary_matrix_test
    {
        _1253_reconstruct_a_2_row_binary_matrix alg = new();

        [TestMethod]
        public void TestCase01()
        {
            int upper = 2, lower = 1;
            int[] colsum = [1, 1, 1];
            IList<IList<int>> exp = [[1, 1, 0], [0, 0, 1]];
            IList<IList<int>> res = alg.ReconstructMatrix(upper, lower, colsum);
            Assert.IsTrue(Utils.IsSameList(exp, res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int upper = 2, lower = 3;
            int[] colsum = [2, 2, 1, 1];
            IList<IList<int>> exp = [];
            IList<IList<int>> res = alg.ReconstructMatrix(upper, lower, colsum);
            Assert.IsTrue(Utils.IsSameList(exp,res));
        }
        [TestMethod]
        public void TestCase03()
        {
            int upper = 5, lower = 5;
            int[] colsum = [2, 1, 2, 0, 1, 0, 1, 2, 0, 1];
            IList<IList<int>> exp = [[1, 0, 1, 0, 0, 0, 1, 1, 0, 1], [1, 1, 1, 0, 1, 0, 0, 1, 0, 0]];
            IList<IList<int>> res = alg.ReconstructMatrix(upper, lower, colsum);
            Assert.IsTrue(Utils.IsSameList(exp, res));
        }

        [TestMethod]
        public void TestCase04()
        {
            int upper = 4, lower = 7;
            int[] colsum = [2, 1, 2, 2, 1, 1, 1];
            IList<IList<int>> exp = [];
            IList<IList<int>> res = alg.ReconstructMatrix(upper, lower, colsum);
            Assert.IsTrue(Utils.IsSameList(exp, res));
        }
    }
}
