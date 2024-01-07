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
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int r = 9; // 选择的元素个数
            int n = numbers.Length;

            GenerateCombinations(numbers, n, r);
        }
        static int Factorial(int n)
        {
            if (n <= 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }
        // 生成组合
        static void GenerateCombinations(int[] arr, int n, int r)
        {
            int totalCombinations = Factorial(n) / (Factorial(r) * Factorial(n - r));
            Console.WriteLine($"总共有 {totalCombinations} 种组合：");

            int[] data = new int[r];
            GenerateCombinationsUtil(arr, data, 0, n - 1, 0, r);
        }

        static void GenerateCombinationsUtil(int[] arr, int[] data, int start, int end, int index, int r)
        {
            if (index == r)
            {
                for (int j = 0; j < r; j++)
                {
                    Console.Write(data[j] + " ");
                }
                Console.WriteLine();
                return;
            }

            for (int i = start; i <= end && end - i + 1 >= r - index; i++)
            {
                data[index] = arr[i];
                GenerateCombinationsUtil(arr, data, i + 1, end, index + 1, r);
            }
        }
    }
}