using leetCode._3001_3050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3301_3350
{
    public class _3024_TypeOfTriangleTest
    {
        _3024_TypeOfTriangleAlg alg = new _3024_TypeOfTriangleAlg();

        [Fact]
        public void Test01()
        {
            int[] nums = [3, 3, 3];
            string exp = "equilateral";
            string res = alg.TriangleType(nums);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] nums = [3, 4, 5];
            string exp = "scalene";
            string res = alg.TriangleType(nums);
            Assert.Equal(exp, res);
        }
    }
}
