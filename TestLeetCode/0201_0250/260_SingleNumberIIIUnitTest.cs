using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0201_0250
{
    [TestClass]
    public class _260_SingleNumberIIIUnitTest
    {
        _260_SingleNumberIIIAlg alg = new _260_SingleNumberIIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 1, 3, 2, 5];
            int[] exp = [3, 5];
            int[] res = alg.SingleNumber(nums);
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [-1, 0];
            int[] exp = [-1, 0];
            int[] res = alg.SingleNumber(nums);
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [0, 1];
            int[] exp = [1, 0];
            int[] res = alg.SingleNumber(nums);
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);
        }
    }
}
