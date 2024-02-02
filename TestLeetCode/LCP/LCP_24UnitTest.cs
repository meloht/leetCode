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
            int[] exp = [0, 154, 375, 704, 704, 1355, 1547, 1617, 1617, 1843, 2142, 2410, 2665, 3046, 3188, 3373, 3710, 3879, 4163, 4272, 4619, 4657, 4698, 5307, 5531, 5721, 6211, 6214, 6283, 6587, 7179, 7729, 7923, 8029, 8186, 8423, 8725, 9049, 9492, 9544, 9836, 10202, 10317, 10337, 10489, 10801, 10823, 10998, 11562, 11624, 11707, 11719, 11957, 12108, 12728, 12735, 13114, 13247, 13581, 13737, 14199, 14487, 14703, 15318, 15659, 16083, 16285, 16850, 16972, 17216, 17586, 17725, 18059, 18415, 18975, 19290, 19398, 19658, 19704, 19839, 20005, 20197, 20628, 20918, 20945, 21269, 21579, 21779, 22368, 22739, 22880, 23300, 23300, 23440, 23484, 23661, 24023, 24191, 24513];
            int[] res = alg.NumsGame(nums);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
