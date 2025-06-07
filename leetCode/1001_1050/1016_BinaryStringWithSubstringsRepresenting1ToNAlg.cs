using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._1001_1050
{
	public class _1016_BinaryStringWithSubstringsRepresenting1ToNAlg
	{
		public bool QueryString1(string s, int n)
		{
			for (int i = 1; i <= n; i++)
			{
				if (!s.Contains(Convert.ToString(i, 2)))
				{
					return false;

				}
			}
			return true;
		}

		public bool QueryString2(string s, int n)
		{
			if (n == 1)
			{
				return s.IndexOf('1') != -1;
			}
			int k = 30;
			while ((1 << k) > n)
			{
				--k;
			}
			if (s.Length < (1 << (k - 1)) + k - 1 || s.Length < n - (1 << k) + k + 1)
			{
				return false;
			}
			return Help(s, k, 1 << (k - 1), (1 << k) - 1) && Help(s, k + 1, 1 << k, n);
		}

		public bool Help(string s, int k, int mi, int ma)
		{
			ISet<int> set = new HashSet<int>();
			int t = 0;
			for (int r = 0; r < s.Length; ++r)
			{
				t = t * 2 + (s[r] - '0');
				if (r >= k)
				{
					t -= (s[r - k] - '0') << k;
				}
				if (r >= k - 1 && t >= mi && t <= ma)
				{
					set.Add(t);
				}
			}
			return set.Count == ma - mi + 1;
		}

		public bool QueryString(string s, int n)
		{
			if (n == 1)
				return s.Contains("1");

			int k = 31 - int.LeadingZeroCount(n); // n 的二进制长度减一
			if (s.Length < Math.Max(n - (1 << k) + k + 1, (1 << (k - 1)) + k - 1))
				return false;

			return check(s, k, n / 2 + 1, (1 << k) - 1) && check(s, k + 1, 1 << k, n);
		}

		// 对于长为 k 的在 [lower, upper] 内的二进制数，判断这些数 s 是否都有
		private bool check(string s, int k, int lower, int upper)
		{
			if (lower > upper) return true;
			var seen = new HashSet<int>();
			int mask = (1 << (k - 1)) - 1;
			int x = Convert.ToInt32(s.Substring(0, k), 2);
			for (int i = k - 1, m = s.Length; i < m; i++)
			{
				// & mask 可以去掉最高比特位，从而实现滑窗的「出」
				// << 1 | (s.charAt(i) - '0') 即为滑窗的「入」
				x = ((x & mask) << 1) | (s[i] - '0');
				if (lower <= x && x <= upper)
					seen.Add(x);
			}
			return seen.Count == upper - lower + 1;
		}




	}
}
