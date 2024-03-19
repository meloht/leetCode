using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0201_0250
{
    [TestClass]
    public class _229_MajorityElementIIUnitTest
    {
        _229_MajorityElementIIAlg alg = new _229_MajorityElementIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [3, 2, 3];
            int[] exp = [3];
            int[] res = alg.MajorityElement(nums).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1];
            int[] exp = [1];
            int[] res = alg.MajorityElement(nums).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 2];
            int[] exp = [1, 2];
            int[] res = alg.MajorityElement(nums).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [2, 2];
            int[] exp = [2];
            int[] res = alg.MajorityElement(nums).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
