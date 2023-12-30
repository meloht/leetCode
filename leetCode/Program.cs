using leetCode._0151_0200;
using leetCode._1_50;
using leetCode._51_100;
using leetCode.WeeklyContest;

namespace leetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _200_NumberOfIslandsAlg alg = new _200_NumberOfIslandsAlg();
            char[][] grid = [
               ['1', '1', '1', '1', '0'],
                ['1', '1', '0', '1', '0'],
                ['1', '1', '0', '0', '0'],
                ['0', '0', '0', '0', '0']
];
            int res = alg.NumIslands(grid);
            Console.WriteLine(res);
        }
    }
}