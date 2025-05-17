using leetCode._3301_3350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3301_3350
{
    public class _3337_TotalCharactersInStringAfterTransformationsIITest
    {
        _3337_TotalCharactersInStringAfterTransformationsIIAlg alg = new _3337_TotalCharactersInStringAfterTransformationsIIAlg();
        [Fact]
        public void Test01()
        {
            string s = "abcyy";
            int t = 2;
            int[] nums = [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2];
            int exp = 7;
            int res = alg.LengthAfterTransformations(s, t, nums);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            string s = "azbk";
            int t = 1;
            int[] nums = [2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2];
            int exp = 8;
            int res = alg.LengthAfterTransformations(s, t, nums);
            Assert.Equal(exp, res);
        }
    }
}
