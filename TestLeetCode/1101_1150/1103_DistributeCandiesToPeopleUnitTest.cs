using leetCode._1101_1150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1101_1150
{
    [TestClass]
    public class _1103_DistributeCandiesToPeopleUnitTest
    {
        _1103_DistributeCandiesToPeopleAlg alg = new _1103_DistributeCandiesToPeopleAlg();

        [TestMethod]
        public void TestCase01()
        {
            int candies = 7, num_people = 4;
            int[] exp = [1, 2, 3, 1];
            int[] res = alg.DistributeCandies(candies, num_people);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int candies = 10, num_people = 3;
            int[] exp = [5, 2, 3];
            int[] res = alg.DistributeCandies(candies, num_people);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

    }
}
