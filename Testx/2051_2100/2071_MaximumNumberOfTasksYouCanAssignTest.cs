using leetCode._2051_2100;
using leetCode.WeeklyContest._0401;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._2051_2100
{
    public class _2071_MaximumNumberOfTasksYouCanAssignTest
    {
        _2071_MaximumNumberOfTasksYouCanAssignAlg alg = new _2071_MaximumNumberOfTasksYouCanAssignAlg();
        [Fact]
        public void Test01()
        {
            int[] tasks = [3, 2, 1], workers = [0, 3, 3];
            int pills = 1, strength = 1;
            int exp = 3;
            int res = alg.MaxTaskAssign(tasks, workers, pills, strength);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] tasks = [5, 4], workers = [0, 0, 0];
            int pills = 1, strength = 5;
            int exp = 1;
            int res = alg.MaxTaskAssign(tasks, workers, pills, strength);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[] tasks = [10, 15, 30], workers = [0, 10, 10, 10, 10];
            int pills = 3, strength = 10;
            int exp = 2;
            int res = alg.MaxTaskAssign(tasks, workers, pills, strength);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test04()
        {
            int[] tasks = [5, 9, 8, 5, 9], workers = [1, 6, 4, 2, 6];
            int pills = 1, strength = 5;
            int exp = 3;
            int res = alg.MaxTaskAssign(tasks, workers, pills, strength);
            Assert.Equal(exp, res);
        }

      
    }
}
