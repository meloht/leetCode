using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0701_0750
{
    public class _732_MyCalendarIIIAlg
    {
        public class MyCalendarThree
        {
            Dictionary<int, int[]> tree;
            public MyCalendarThree()
            {
                tree = new Dictionary<int, int[]>();
            }

            public int Book(int startTime, int endTime)
            {
                Update(startTime, endTime - 1, 1, 0, 1000000000, 1);
        
                return tree[1][0];
            }

            public void Update(int start, int end, int val, int l, int r, int idx)
            {
                if (r < start || end < l)
                {
                    return;
                }
                if (!tree.ContainsKey(idx))
                {
                    tree.Add(idx, new int[2]);
                }
                if (start <= l && r <= end)
                {
                    tree[idx][0] += val;
                    tree[idx][1] += val;
                }
                else
                {
                    int mid = (l + r) >> 1;
                    Update(start, end, val, l, mid, 2 * idx);
                    Update(start, end, val, mid + 1, r, 2 * idx + 1);
                    if (!tree.ContainsKey(2 * idx))
                    {
                        tree.Add(2 * idx, new int[2]);
                    }
                    if (!tree.ContainsKey(2 * idx + 1))
                    {
                        tree.Add(2 * idx + 1, new int[2]);
                    }
                    tree[idx][0] = tree[idx][1] + Math.Max(tree[2 * idx][0], tree[2 * idx + 1][0]);
                }
            }
        }


        public class MyCalendarThree1
        {
            //动态开点线段树区间查询修改
            Node root;
            public MyCalendarThree1()
            {
                root = new Node(0, 1000000000);
            }

            public int Book(int startTime, int endTime)
            {

                Update(root, startTime, endTime - 1);


                return root.max;

            }

            //查找区间内最大值
            int Check(Node n, int left, int right)
            {
                if (left <= n.l && right >= n.r)
                    return n.max;

                int mid = (n.l + n.r) / 2;

                if (n.ln == null)
                    n.ln = new Node(n.l, mid);
                if (n.rn == null)
                    n.rn = new Node(mid + 1, n.r);

                //更新lazy
                if (n.lazy > 0)
                {
                    n.ln.lazy += n.lazy;
                    n.ln.max += n.lazy;

                    n.rn.lazy += n.lazy;
                    n.rn.max += n.lazy;

                    n.lazy = 0;


                }

                int b = 0;
                if (left <= mid)
                    b = Math.Max(b, Check(n.ln, left, right));
                if (right > mid)
                    b = Math.Max(b, Check(n.rn, left, right));

                return b;

            }

            //更新区间内+1
            void Update(Node n, int left, int right)
            {
                if (left <= n.l && right >= n.r)
                {
                    n.max++;
                    n.lazy++;
                    return;
                }

                int mid = (n.l + n.r) / 2;
                if (n.ln == null)
                    n.ln = new Node(n.l, mid);
                if (n.rn == null)
                    n.rn = new Node(mid + 1, n.r);

                //更新lazy
                if (n.lazy > 0)
                {
                    n.ln.lazy += n.lazy;
                    n.ln.max += n.lazy;

                    n.rn.lazy += n.lazy;
                    n.rn.max += n.lazy;

                    n.lazy = 0;


                }


                if (left <= mid)
                    Update(n.ln, left, right);
                if (right > mid)
                    Update(n.rn, left, right);

                n.max = Math.Max(n.ln.max, n.rn.max);



            }


        }

        /**
         * Your MyCalendar object will be instantiated and called as such:
         * MyCalendar obj = new MyCalendar();
         * bool param_1 = obj.Book(startTime,endTime);
         */

        public class Node
        {
            public int l;
            public int r;
            public Node ln;
            public Node rn;
            public int max;
            //区间增加的值
            public int lazy;
            public Node(int l, int r)
            {
                this.l = l;
                this.r = r;

            }
        }
    }
}
