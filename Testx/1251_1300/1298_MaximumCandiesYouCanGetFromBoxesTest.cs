using leetCode._1251_1300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._1251_1300
{
    public class _1298_MaximumCandiesYouCanGetFromBoxesTest
    {
        _1298_MaximumCandiesYouCanGetFromBoxesAlg alg = new _1298_MaximumCandiesYouCanGetFromBoxesAlg();

        [Fact]
        public void Test01()
        {
            int[] status = [1, 0, 1, 0], candies = [7, 5, 4, 100];
            int[][] keys = [[], [], [1], []], containedBoxes = [[1, 2], [3], [], []];
            int[] initialBoxes = [0];
            int exp = 16;
            int res = alg.MaxCandies(status, candies, keys, containedBoxes, initialBoxes);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] status = [1, 0, 0, 0, 0, 0], candies = [1, 1, 1, 1, 1, 1];
            int[][] keys = [[1, 2, 3, 4, 5], [], [], [], [], []], containedBoxes = [[1, 2, 3, 4, 5], [], [], [], [], []];
            int[] initialBoxes = [0];
            int exp = 6;
            int res = alg.MaxCandies(status, candies, keys, containedBoxes, initialBoxes);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[] status = [1, 1, 1], candies = [100, 1, 100];
            int[][] keys = [[], [0, 2], []], containedBoxes = [[], [], []];
            int[] initialBoxes = [1];
            int exp = 1;
            int res = alg.MaxCandies(status, candies, keys, containedBoxes, initialBoxes);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test04()
        {
            int[] status = [1], candies = [100];
            int[][] keys = [[]], containedBoxes = [[]];
            int[] initialBoxes = [];
            int exp = 0;
            int res = alg.MaxCandies(status, candies, keys, containedBoxes, initialBoxes);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test05()
        {
            int[] status = [1, 1, 1], candies = [2, 3, 2];
            int[][] keys = [[], [], []], containedBoxes = [[], [], []];
            int[] initialBoxes = [2, 1, 0];
            int exp = 7;
            int res = alg.MaxCandies(status, candies, keys, containedBoxes, initialBoxes);
            Assert.Equal(exp, res);
        }
    }
}
