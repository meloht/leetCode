using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._0751_0800
{
    public class _756_PyramidTransitionMatrixAlg
    {
        int[,] T;
        HashSet<long> seen;

        public bool PyramidTransition2(string bottom, IList<string> allowed)
        {
            T = new int[7, 7];
            foreach (string a in allowed)
                T[a[0] - 'A', a[1] - 'A'] |= 1 << (a[2] - 'A');

            seen = new HashSet<long>();
            int N = bottom.Length;
            int[,] A = new int[N, N];
            int t = 0;
            foreach (char c in bottom)
                A[N - 1,t++] = c - 'A';
            return solve(A, 0, N - 1, 0);
        }

        //A[i] - the ith row of the pyramid
        //R - integer representing the current row of the pyramid
        //N - length of current row we are calculating
        //i - index of how far in the current row we are calculating
        //Returns true iff pyramid can be built
        public bool solve(int[,] A, long R, int N, int i)
        {
            if (N == 1 && i == 1)
            { // If successfully placed entire pyramid
                return true;
            }
            else if (i == N)
            {
                if (seen.Contains(R)) return false; // If we've already tried this row, give up
                seen.Add(R); // Add row to cache
                return solve(A, 0, N - 1, 0); // Calculate next row
            }
            else
            {
                // w's jth bit is true iff block #j could be
                // a parent of A[N][i] and A[N][i+1]
                int w = T[A[N,i],A[N,i + 1]];
                // for each set bit in w...
                for (int b = 0; b < 7; ++b) if (((w >> b) & 1) != 0)
                    {
                        A[N - 1,i] = b; //set parent to be equal to block #b
                                         //If rest of pyramid can be built, return true
                                         //R represents current row, now with ith bit set to b+1
                                         // in base 8.
                        if (solve(A, R * 8 + (b + 1), N, i + 1)) return true;
                    }
                return false;
            }
        }

        public bool PyramidTransition(string bottom, IList<string> allowed)
        {
            HashSet<char>[,] nexts = new HashSet<char>[6, 6];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    nexts[i, j] = new HashSet<char>();
                }
            }
            foreach (var item in allowed)
            {
                int i = item[0] - 'A';
                int j = item[1] - 'A';
                nexts[i, j].Add(item[2]);
            }
            HashSet<string> set = new HashSet<string>();
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(bottom);

            while (queue.Count > 0)
            {
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    string arr = queue.Dequeue();

                    for (int j = 0; j < arr.Length - 1; j++)
                    {
                        if (AddNextNode(arr, 0, new List<char>(), nexts, queue, set) == 1)
                        {
                            return true;
                        }
                    }

                }
            }

            return false;
        }

        private int AddNextNode(string arr, int idx, List<char> ls, HashSet<char>[,] nexts, Queue<string> queue, HashSet<string> set)
        {
            if (idx == arr.Length - 1)
            {
                if (ls.Count == 1)
                {
                    return 1;
                }

                if (ls.Count == 2)
                {
                    if (nexts[ls[0] - 'A', ls[1] - 'A'].Count > 0)
                    {
                        return 1;
                    }
                }

                var item = new string(ls.ToArray());

                if (set.Add(item))
                {
                    queue.Enqueue(item);
                }

                return 0;
            }

            int m = arr[idx] - 'A';
            int n = arr[idx + 1] - 'A';
            var nextNodes = nexts[m, n];
            if (nextNodes.Count == 0)
            {
                return -1;
            }

            foreach (var ch in nextNodes)
            {
                if (ls.Count == 0)
                {
                    ls.Add(ch);

                    int res = AddNextNode(arr, idx + 1, ls, nexts, queue, set);
                    if (res == 1 || res == -1)
                        return res;
                    ls.RemoveAt(ls.Count - 1);
                }
                else
                {
                    if (nexts[ls[ls.Count - 1] - 'A', ch - 'A'].Count > 0)
                    {
                        ls.Add(ch);
                        int res = AddNextNode(arr, idx + 1, ls, nexts, queue, set);
                        if (res == 1 || res == -1)
                            return res;
                        ls.RemoveAt(ls.Count - 1);
                    }
                }
            }

            return 0;
        }

    }
}
