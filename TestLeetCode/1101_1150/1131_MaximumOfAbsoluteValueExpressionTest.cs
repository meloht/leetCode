using leetCode._1101_1150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1101_1150
{
    [TestClass]
    public class _1131_MaximumOfAbsoluteValueExpressionTest
    {
        _1131_MaximumOfAbsoluteValueExpressionAlg alg = new _1131_MaximumOfAbsoluteValueExpressionAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] arr1 = [1, 2, 3, 4], arr2 = [-1, 4, 5, 6];
            int exp = 13;
            int res = alg.MaxAbsValExpr(arr1, arr2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] arr1 = [1, -2, -5, 0, 10], arr2 = [0, -2, -1, -7, -4];
            int exp = 20;
            int res = alg.MaxAbsValExpr(arr1, arr2);
            Assert.AreEqual(exp, res);
        }
    }


}
