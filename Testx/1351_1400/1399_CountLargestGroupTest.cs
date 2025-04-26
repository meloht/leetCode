using leetCode._1351_1400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._1351_1400
{
    public class _1399_CountLargestGroupTest
    {
        _1399_CountLargestGroupAlg alg = new _1399_CountLargestGroupAlg();

        [Fact]
        public void Test1()
        {
            int n = 13;
            int exp = 4;
            int res = alg.CountLargestGroup(n);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test2()
        {
            int n = 2;
            int exp = 2;
            int res = alg.CountLargestGroup(n);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test3()
        {
            int n = 15;
            int exp = 6;
            int res = alg.CountLargestGroup(n);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test4()
        {
            int n = 24;
            int exp = 5;
            int res = alg.CountLargestGroup(n);
            Assert.Equal(exp, res);
        }
    }
}
