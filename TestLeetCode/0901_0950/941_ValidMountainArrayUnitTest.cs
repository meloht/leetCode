using leetCode._0901_0950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0901_0950
{
    [TestClass]
    public class _941_ValidMountainArrayUnitTest
    {
        _941_ValidMountainArrayAlg alg = new _941_ValidMountainArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] arr = [2, 1];
            bool exp = false;
            bool res = alg.ValidMountainArray(arr);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase02()
        {
            int[] arr = [3, 5, 5];
            bool exp = false;
            bool res = alg.ValidMountainArray(arr);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] arr = [0, 3, 2, 1];
            bool exp = true;
            bool res = alg.ValidMountainArray(arr);
            Assert.AreEqual(exp, res);
        }
    }
}
