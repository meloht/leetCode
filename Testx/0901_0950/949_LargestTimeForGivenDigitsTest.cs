using leetCode._0901_0950;
using leetCode.WeeklyContest._0401;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0901_0950
{
    public class _949_LargestTimeForGivenDigitsTest
    {
        _949_LargestTimeForGivenDigitsAlg alg = new _949_LargestTimeForGivenDigitsAlg();
        
        [Fact]
        public void Test01()
        {
            int[] arr = [1, 2, 3, 4];
            string exp = "23:41";
            string res = alg.LargestTimeFromDigits(arr);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] arr = [5, 5, 5, 5];
            string exp = "";
            string res = alg.LargestTimeFromDigits(arr);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[] arr = [0, 0, 0, 0];
            string exp = "00:00";
            string res = alg.LargestTimeFromDigits(arr);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test04()
        {
            int[] arr = [0, 0, 1, 0];
            string exp = "10:00";
            string res = alg.LargestTimeFromDigits(arr);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test05()
        {
            int[] arr = [0, 4, 0, 0];
            string exp = "04:00";
            string res = alg.LargestTimeFromDigits(arr);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test06()
        {
            int[] arr = [2, 0, 6, 6];
            string exp = "06:26";
            string res = alg.LargestTimeFromDigits(arr);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test07()
        {
            int[] arr = [4, 1, 0, 0];
            string exp = "14:00";
            string res = alg.LargestTimeFromDigits(arr);
            Assert.Equal(exp, res);
        }
    }
}
