using leetCode._1_50;

namespace leetCode
{
    internal class Program
    {
        public static IList<IList<int>> GetPermutations(int[] candidates)
        {
            IList<IList<int>> result = new List<IList<int>>();
            List<int> current = new List<int>();
            Array.Sort(candidates); // 对数组进行排序以确保相同元素的排列组合唯一

            bool[] used = new bool[candidates.Length];
            Permute(candidates, current, result, used);

            return result;
        }
        private static void Permute(int[] candidates, List<int> current, IList<IList<int>> result, bool[] used)
        {
            if (current.Count == candidates.Length)
            {
                result.Add(new List<int>(current));
                return;
            }

            for (int i = 0; i < candidates.Length; i++)
            {
                if (used[i] || (i > 0 && candidates[i] == candidates[i - 1] && !used[i - 1]))
                {
                    continue; // 跳过重复元素
                }

                used[i] = true;
                current.Add(candidates[i]);
                Permute(candidates, current, result, used);
                used[i] = false;
                current.RemoveAt(current.Count - 1);
            }
        }
        static void Main(string[] args)
        {
            int[] candidates = { 1,2,3 };
            IList<IList<int>> permutations = GetPermutations(candidates);

            Console.WriteLine("Permutations:");
            foreach (var permutation in permutations)
            {
                Console.WriteLine(string.Join(", ", permutation));
            }


        }
    }
}