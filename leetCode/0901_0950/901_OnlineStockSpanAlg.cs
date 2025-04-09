using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _901_OnlineStockSpanAlg
    {
        public class StockSpanner
        {

            int idx = -1;
            Stack<(int index, int price)> stack = new Stack<(int, int)>();
            public StockSpanner()
            {

            }

            public int Next(int price)
            {
                idx++;
                while (stack.Count > 0 && stack.Peek().price <= price)
                {
                    stack.Pop();
                }
                int index = -1;
                if (stack.Count > 0)
                {
                    index = stack.Peek().index;
                }

                stack.Push((idx, price));


                return idx - index;
            }
        }


    }
}
