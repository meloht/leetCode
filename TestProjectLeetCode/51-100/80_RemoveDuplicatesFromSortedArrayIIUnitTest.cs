using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._51_100
{
    [TestClass]
    public class _80_RemoveDuplicatesFromSortedArrayIIUnitTest
    {
        _80_RemoveDuplicatesFromSortedArrayIIAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _80_RemoveDuplicatesFromSortedArrayIIAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            int[] arr = { 1, 1, 1, 2, 2, 3 };

            var res = alg.RemoveDuplicates(arr);

            Assert.AreEqual(5, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] arr = { 0, 0, 1, 1, 1, 1, 2, 3, 3 };

            var res = alg.RemoveDuplicates(arr);

            Assert.AreEqual(7, res);
        }
    }
}
