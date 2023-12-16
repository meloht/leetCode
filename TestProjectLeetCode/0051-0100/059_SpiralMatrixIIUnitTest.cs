using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._51_100
{
    [TestClass]
    public class _59_SpiralMatrixIIUnitTest
    {
        _59_SpiralMatrixIIAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _59_SpiralMatrixIIAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            int n = 3;
            var num = alg.GenerateMatrix(n);
            var arr = new int[][] { [1, 2, 3], [8, 9, 4], [7, 6, 5] };
            bool bl = Utils.IsSameArr(arr, num);
            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 1;
            var num = alg.GenerateMatrix(n);
            var arr = new int[][] { [1] };
            bool bl = Utils.IsSameArr(arr, num);
            Assert.AreEqual(true, bl);
        }
    }
}
