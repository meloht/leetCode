using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _442_FindAllDuplicatesInAnArrayTest
    {
        _442_FindAllDuplicatesInAnArrayAlg alg = new _442_FindAllDuplicatesInAnArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [4, 3, 2, 7, 8, 2, 3, 1];
            int[] exp = [2, 3];
            int[] res = alg.FindDuplicates(nums).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }
        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 1, 2];
            int[] exp = [1];
            int[] res = alg.FindDuplicates(nums).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1];
            int[] exp = [];
            int[] res = alg.FindDuplicates(nums).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
