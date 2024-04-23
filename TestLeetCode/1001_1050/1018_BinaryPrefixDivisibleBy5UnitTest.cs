using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1001_1050
{
    [TestClass]
    public class _1018_BinaryPrefixDivisibleBy5UnitTest
    {
        _1018_BinaryPrefixDivisibleBy5Alg alg = new _1018_BinaryPrefixDivisibleBy5Alg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [0, 1, 1];
            bool[] exp = [true, false, false];
            bool[] res = alg.PrefixesDivBy5(nums).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }


        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 1, 1];
            bool[] exp = [false, false, false];
            bool[] res = alg.PrefixesDivBy5(nums).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 1, 0, 0, 0, 1, 0, 0, 1];
            bool[] exp = [false, false, false, false, false, false, false, false, false];
            bool[] res = alg.PrefixesDivBy5(nums).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
