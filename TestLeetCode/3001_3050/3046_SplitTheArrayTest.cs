using leetCode._3001_3050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3001_3050
{
    [TestClass]
    public class _3046_SplitTheArrayTest
    {
        _3046_SplitTheArrayAlg alg = new _3046_SplitTheArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 1, 2, 2, 3, 4];
            bool exp = true;
            bool res = alg.IsPossibleToSplit(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 1, 1, 1];
            bool exp = false;
            bool res = alg.IsPossibleToSplit(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
