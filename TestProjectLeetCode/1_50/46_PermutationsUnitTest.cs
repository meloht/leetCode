using leetCode._1_50;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._1_50
{
    [TestClass]
    public class _46_PermutationsUnitTest
    {
        _46_PermutationsAlg alg;

        [TestInitialize]
        public void Init()
        {
            alg = new _46_PermutationsAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            var nums = new int[] { 2, 3, 1, 1, 4 };
            var res = alg.Permute(nums);
            Assert.AreEqual(2, res);
        }
    }
}
