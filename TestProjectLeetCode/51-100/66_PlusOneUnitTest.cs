using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._51_100
{
    [TestClass]
    public class _66_PlusOneUnitTest
    {
        _66_PlusOneAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _66_PlusOneAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            var digits = new int[] { 1, 2, 3 };
            var res = alg.PlusOne(digits);
            var exp = new int[] { 1, 2, 4 };
            Assert.AreEqual(true, exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            var digits = new int[] { 4, 3, 2, 1 };
            var res = alg.PlusOne(digits);
            var exp = new int[] { 4, 3, 2, 2 };
            Assert.AreEqual(true, exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            var digits = new int[] { 0 };
            var res = alg.PlusOne(digits);
            var exp = new int[] { 1 };
            Assert.AreEqual(true, exp.SequenceEqual(res));
        }
        [TestMethod]
        public void TestCase04()
        {
            var digits = new int[] { 9,9 };
            var res = alg.PlusOne(digits);
            var exp = new int[] { 1,0,0 };
            Assert.AreEqual(true, exp.SequenceEqual(res));
        }
    }
}
