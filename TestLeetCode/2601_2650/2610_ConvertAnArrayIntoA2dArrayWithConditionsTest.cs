using leetCode._2601_2650;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2601_2650
{
    [TestClass]
    public class _2610_ConvertAnArrayIntoA2dArrayWithConditionsTest
    {
        _2610_ConvertAnArrayIntoA2dArrayWithConditionsAlg alg = new _2610_ConvertAnArrayIntoA2dArrayWithConditionsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 3, 4, 1, 2, 3, 1];
            IList<IList<int>> exp = [[1, 3, 4, 2], [1, 3], [1]];
            var res = alg.FindMatrix(nums);
            Assert.IsTrue(Utils.IsSame(exp,res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 3, 4];
            IList<IList<int>> exp = [[4, 3, 2, 1]];
            var res = alg.FindMatrix(nums);
            Assert.IsTrue(Utils.IsSame(exp, res));
        }
    }
}
