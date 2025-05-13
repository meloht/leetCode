using leetCode._2701_2750;
using leetCode._3301_3350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3301_3350
{
    public class _3335_TotalCharactersInStringAfterTransformationsITest
    {

        _3335_TotalCharactersInStringAfterTransformationsIAlg alg = new _3335_TotalCharactersInStringAfterTransformationsIAlg();

        [Fact]
        public void Test01()
        {
            string s = "abcyy";
            int t = 2;
            int exp = 7;
            int res = alg.LengthAfterTransformations(s, t);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            string s = "azbk";
            int t = 1;
            int exp = 5;
            int res = alg.LengthAfterTransformations(s, t);
            Assert.Equal(exp, res);
        }
    }
}
