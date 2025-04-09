using leetCode._0901_0950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0901_0950
{
    public class _904_FruitIntoBasketsTest
    {
        _904_FruitIntoBasketsAlg alg = new _904_FruitIntoBasketsAlg();


        [Fact]
        public void Test01()
        {
            int[] fruits = [1, 2, 1];
            int exp = 3;
            int res = alg.TotalFruit(fruits);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] fruits = [0, 1, 2, 2];
            int exp = 3;
            int res = alg.TotalFruit(fruits);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[] fruits = [1, 2, 3, 2, 2];
            int exp = 4;
            int res = alg.TotalFruit(fruits);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test04()
        {
            int[] fruits = [3, 3, 3, 1, 2, 1, 1, 2, 3, 3, 4];
            int exp = 5;
            int res = alg.TotalFruit(fruits);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test05()
        {
            int[] fruits = [0, 0, 1, 1];
            int exp = 4;
            int res = alg.TotalFruit(fruits);
            Assert.Equal(exp, res);
        }


        [Fact]
        public void Test06()
        {
            int[] fruits = [1, 0, 1, 4, 1, 4, 1, 2, 3];
            int exp = 5;
            int res = alg.TotalFruit(fruits);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test07()
        {
            int[] fruits = [1, 0, 3, 4, 3];
            int exp = 3;
            int res = alg.TotalFruit(fruits);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test08()
        {
            int[] fruits = [1, 9, 1, 8, 22, 0, 22, 19, 19, 2, 19, 6, 6, 19, 2, 20, 2, 9, 9, 9, 9, 16, 19, 16, 19, 11, 19, 0, 19, 19];
            int exp = 5;
            int res = alg.TotalFruit(fruits);
            Assert.Equal(exp, res);
        }
    }
}
