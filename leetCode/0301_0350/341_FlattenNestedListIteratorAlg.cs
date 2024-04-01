using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _341_FlattenNestedListIteratorAlg
    {
        public class NestedIterator
        {
            Stack<NestedInteger> stack;

            public NestedIterator(IList<NestedInteger> nestedList)
            {
                stack = new Stack<NestedInteger>();
                for (int i = nestedList.Count - 1; i >= 0; i--)
                {
                    stack.Push(nestedList[i]);
                }

            }

            public bool HasNext()
            {
                while (stack.Count > 0)
                {
                    if (stack.Peek().IsInteger())
                    {
                        return true;
                    }
                    var item = stack.Pop();
                    var ls = item.GetList();
                    for (int i = ls.Count - 1; i >= 0; i--)
                    {
                        stack.Push(ls[i]);
                    }
                }
                return false;
            }

            public int Next()
            {
                var num = stack.Pop().GetInteger();
                return num;
            }
        }



        public interface NestedInteger
        {
            // @return true if this NestedInteger holds a single integer, rather than a nested list.
            bool IsInteger();

            // @return the single integer that this NestedInteger holds, if it holds a single integer
            // Return null if this NestedInteger holds a nested list
            int GetInteger();

            // @return the nested list that this NestedInteger holds, if it holds a nested list
            // Return null if this NestedInteger holds a single integer
            IList<NestedInteger> GetList();



        }

        public class NestedIntegerImpl : NestedInteger
        {
            private int num;
            private List<NestedInteger> list = new List<NestedInteger>();
            private bool isNum = false;

            public NestedIntegerImpl(int n)
            {
                isNum = true;
                num = n;
            }
            public NestedIntegerImpl(int n, bool bl)
            {
                isNum = bl;
                num = n;
            }
            public NestedIntegerImpl(int[] ns)
            {
                isNum = false;
                list = new List<NestedInteger>(ns.Length);
                foreach (var item in ns)
                {
                    list.Add(new NestedIntegerImpl(item, true));
                }
            }
            public int GetInteger()
            {
                return num;
            }

            public IList<NestedInteger> GetList()
            {
                return list;
            }

            public bool IsInteger()
            {
                return isNum;
            }

            public override string ToString()
            {
                if (list != null)
                {
                    string s = string.Join(",", list);
                    return s;
                }
                return num.ToString();
            }

            public static NestedInteger Build(int num)
            {
                NestedIntegerImpl nestedInteger = new NestedIntegerImpl(num);
                return nestedInteger;
            }

            public static NestedInteger Build(int[] nums)
            {
                NestedIntegerImpl nestedInteger = new NestedIntegerImpl(nums);
                return nestedInteger;
            }
        }

    }
}
