using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _448_FindAllNumbersDisappearedInAnArrayUnitTest
    {
        _448_FindAllNumbersDisappearedInAnArrayAlg alg = new _448_FindAllNumbersDisappearedInAnArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [4, 3, 2, 7, 8, 2, 3, 1];
            int[] exp = [5, 6];
            int[] res = alg.FindDisappearedNumbers(nums).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 1];
            int[] exp = [2];
            int[] res = alg.FindDisappearedNumbers(nums).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
