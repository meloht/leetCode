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

        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [471, 626, 848, 957, 788, 138, 982, 721, 729, 956, 432, 1000, 478, 353, 586, 544, 304, 811, 359, 535, 992, 684, 606, 39, 384, 799, 120, 608, 540, 914, 19, 62, 410, 711, 449, 370, 263, 890, 124, 516, 861, 936, 729, 595, 768, 929, 649, 803, 65, 692, 548, 620, 871, 785, 15, 629, 251, 764, 973, 484, 172, 923, 859, 29, 297, 215, 436, 74, 762, 885, 272, 504, 307, 998, 83, 329, 520, 889, 584, 496, 443, 802, 180, 322, 640, 290, 292, 403, 11, 230, 743, 183, 600, 741, 558, 780, 970, 777, 288];
            int[] exp = [0, 154, 397, 704, 752, 1355, 1645, 1667, 1687, 1849, 2215, 2420, 2726, 3130, 3238, 3373, 3718, 3879, 4164, 4272, 4632, 4657, 4709, 5307, 5547, 5721, 6215, 6222, 6289, 6611, 7182, 7753, 7940, 8057, 8203, 8423, 8734, 9049, 9497, 9552, 9847, 10202, 10335, 10337, 10504, 10817, 10853, 11028, 11613, 11694, 11755, 11769, 12000, 12150, 12811, 12829, 13224, 13365, 13679, 13831, 14316, 14593, 14808, 15460, 15811, 16241, 16419, 16982, 17131, 17398, 17750, 17857, 18165, 18537, 19091, 19376, 19451, 19732, 19748, 19857, 20015, 20213, 20641, 20924, 20964, 21285, 21598, 21799, 22398, 22771, 22920, 23344, 23356, 23506, 23535, 23715, 24068, 24243, 24563];
            int[] res = alg.NumsGame(nums);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
