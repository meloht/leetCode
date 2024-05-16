using leetCode._1951_2000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1951_2000
{
    [TestClass]
    public class _1953_MaximumNumberOfWeeksForWhichYouCanWorkUnitTest
    {
        _1953_MaximumNumberOfWeeksForWhichYouCanWorkAlg alg = new _1953_MaximumNumberOfWeeksForWhichYouCanWorkAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] milestones = [1, 2, 3];
            long exp = 6;
            long res = alg.NumberOfWeeks(milestones);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] milestones = [5, 2, 1];
            long exp = 7;
            long res = alg.NumberOfWeeks(milestones);
            Assert.AreEqual(exp, res);
        }


    }
}
