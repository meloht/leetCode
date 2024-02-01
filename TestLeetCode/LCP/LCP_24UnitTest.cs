using leetCode.LCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LCP
{
   
    [TestClass]
    public class LCP_24UnitTest
    {
        LCP_24 alg = new LCP_24();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [3, 4, 5, 1, 6, 7];
            int[] exp = [0, 0, 0, 5, 6, 7];
            int[] res = alg.NumsGame(nums);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 3, 4, 5];
            int[] exp = [0, 0, 0, 0, 0];
            int[] res = alg.NumsGame(nums);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 1, 1, 2, 3, 4];
            int[] exp = [0, 1, 2, 3, 3, 3];
            int[] res = alg.NumsGame(nums);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
