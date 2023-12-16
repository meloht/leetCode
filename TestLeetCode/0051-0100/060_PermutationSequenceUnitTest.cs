using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._51_100
{
    [TestClass]
    public class _60_PermutationSequenceUnitTest
    {
        _60_PermutationSequenceAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _60_PermutationSequenceAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            string res = "213";
            var dd = alg.GetPermutation(3, 3);
            Assert.AreEqual(res, dd);
        }

        [TestMethod]
        public void TestCase02()
        {
            string res = "2314";
            var dd = alg.GetPermutation(4, 9);
            Assert.AreEqual(res, dd);
        }

        [TestMethod]
        public void TestCase03()
        {
            string res = "123";
            var dd = alg.GetPermutation(3, 1);
            Assert.AreEqual(res, dd);
        }

        [TestMethod]
        public void TestCase04()
        {
            string res = "21";
            var dd = alg.GetPermutation(2, 2);
            Assert.AreEqual(res, dd);
        }

        [TestMethod]
        public void TestCase05()
        {
            string res = "132";
            var dd = alg.GetPermutation(3, 2);
            Assert.AreEqual(res, dd);
        }


        [TestMethod]
        public void TestCase06()
        {
            string res = "1432";
            var dd = alg.GetPermutation(4, 6);
            Assert.AreEqual(res, dd);
        }
    }
}
