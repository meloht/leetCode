using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _853_CarFleetAlg
    {
        public int CarFleet(int target, int[] position, int[] speed)
        {
            int n = position.Length;

            PoSp[] arr = new PoSp[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = new PoSp(position[i], (double)(target - position[i]) / speed[i]);
            }

            Array.Sort(arr, (x, y) => x.Position - y.Position);

            Stack<PoSp> stack = new Stack<PoSp>();
            for (int i = 0; i < n; i++)
            {
                var item = arr[i];
                if (stack.Count == 0)
                {
                    stack.Push(item);
                    continue;
                }
                if (stack.Peek().Time > item.Time)
                {
                    stack.Push(item);
                }
                else
                {
                    while (stack.Count > 0 && stack.Peek().Time <= item.Time)
                    {
                        stack.Pop();
                    }
                    stack.Push(item);
                }
            }

            return stack.Count;
        }

        public struct PoSp
        {
            public int Position;
            public double Time;

            public PoSp(int p, double time)
            {
                Position = p;
                Time = time;
            }
        }
    }
}
