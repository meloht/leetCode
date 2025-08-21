using leetCode._1051_1100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1051_1100
{
    [TestClass]
    public class _1072_FlipColumnsForMaximumNumberOfEqualRowsTest
    {
        _1072_FlipColumnsForMaximumNumberOfEqualRowsAlg alg = new _1072_FlipColumnsForMaximumNumberOfEqualRowsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] matrix = [
                [0, 1], 
                [1, 1]];
            int exp = 1;
            int res = alg.MaxEqualRowsAfterFlips(matrix);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] matrix = [
                [0, 1], 
                [1, 0]];
            int exp = 2;
            int res = alg.MaxEqualRowsAfterFlips(matrix);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase03()
        {
            int[][] matrix = [
                [0, 0, 0], 
                [0, 0, 1], 
                [1, 1, 0]];
            int exp = 2;
            int res = alg.MaxEqualRowsAfterFlips(matrix);
            Assert.AreEqual(exp, res);
        }
    }
}
