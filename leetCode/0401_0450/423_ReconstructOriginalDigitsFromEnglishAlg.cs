using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _423_ReconstructOriginalDigitsFromEnglishAlg
    {
        public string OriginalDigits(string s)
        {
            int[] arr = new int[26];
            StringBuilder sb = new StringBuilder();
            List<string> list = new List<string>();
            foreach (char item in s)
            {
                int idx = item - 'a';
                arr[idx]++;
            }
            int[] res = new int[10];

            string[] nums1 = ["zero", "two", "six", "eight"];
            int[] nums1str = [0, 2, 6, 8];

            AddNum(nums1, nums1str, res, arr);

            string[] nums2 = ["four", "seven"];
            int[] nums2str = [4, 7];
            AddNum(nums2, nums2str, res, arr);

            string[] nums3 = ["five", "three"];
            int[] nums3str = [5, 3];
            AddNum(nums3, nums3str, res, arr);

            string[] nums = ["nine", "one"];
            int[] numsstr = [9, 1];
            AddNum(nums, numsstr, res, arr);

            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < res[i]; ++j)
                {
                    sb.Append((char)(i + '0'));
                }
            }
          
            return sb.ToString();
        }
        private void AddNum(string[] nums, int[] strs, int[] res, int[] arr)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                while (IsContain(num, arr))
                {
                    foreach (var ar in num)
                    {
                        int idx = ar - 'a';
                        arr[idx]--;
                    }
                    res[strs[i]]++;
                }

            }
        }
        private bool IsContain(string s, int[] arr)
        {
            foreach (var ch in s)
            {
                int idx = ch - 'a';
                if (arr[idx] == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public string OriginalDigits1(string s)
        {
            Dictionary<char, int> c = new Dictionary<char, int>();
            foreach (char ch in s)
            {
                if (!c.ContainsKey(ch))
                {
                    c.Add(ch, 0);
                }
                ++c[ch];
            }

            int[] cnt = new int[10];
            cnt[0] = c.ContainsKey('z') ? c['z'] : 0;
            cnt[2] = c.ContainsKey('w') ? c['w'] : 0;
            cnt[4] = c.ContainsKey('u') ? c['u'] : 0;
            cnt[6] = c.ContainsKey('x') ? c['x'] : 0;
            cnt[8] = c.ContainsKey('g') ? c['g'] : 0;

            cnt[3] = (c.ContainsKey('h') ? c['h'] : 0) - cnt[8];
            cnt[5] = (c.ContainsKey('f') ? c['f'] : 0) - cnt[4];
            cnt[7] = (c.ContainsKey('s') ? c['s'] : 0) - cnt[6];

            cnt[1] = (c.ContainsKey('o') ? c['o'] : 0) - cnt[0] - cnt[2] - cnt[4];

            cnt[9] = (c.ContainsKey('i') ? c['i'] : 0) - cnt[5] - cnt[6] - cnt[8];

            StringBuilder ans = new StringBuilder();
            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < cnt[i]; ++j)
                {
                    ans.Append((char)(i + '0'));
                }
            }
            return ans.ToString();
        }

    }
}
