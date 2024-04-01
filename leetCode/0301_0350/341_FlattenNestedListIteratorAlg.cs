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
            Stack<NodeData> stack = new Stack<NodeData>();
            IList<NestedInteger> _nestedList;
            public NestedIterator(IList<NestedInteger> nestedList)
            {
                _nestedList = nestedList;
                stack.Push(new NodeData(_nestedList, 0));
            }

            public bool HasNext()
            {
                if (stack.Count > 0)
                {
                    return true;
                }
                return false;
            }

            public int Next()
            {
                var item = stack.Peek();
                var next = item.Data[item.Index];
                if (next.IsInteger())
                {
                    if (item.Index == item.Data.Count - 1)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        item.Index++;
                    }

                    return next.GetInteger();
                }
                else
                {
                    while (next.IsInteger() == false)
                    {
                        stack.Push(new NodeData(next.GetList(), 1));
                        next = next.GetList()[0];
                    }

                    return next.GetInteger();
                }
            }
        }

        public class NodeData
        {
            public IList<NestedInteger> Data;
            public int Index;

            public NodeData(IList<NestedInteger> item, int i)
            {
                Data = item;
                Index = i;
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
            private List<NestedInteger> list;
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
                    list.Add(new NestedIntegerImpl(item, false));
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
