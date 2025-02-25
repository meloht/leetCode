using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2501_2550
{
    public class _2502_DesignMemoryAllocatorAlg
    {
        public class Allocator
        {
            private int n;
            private int[] memory;

            public Allocator(int n)
            {
                this.n = n;
                this.memory = new int[n];
            }

            public int Allocate(int size, int mID)
            {
                int count = 0;
                for (int i = 0; i < n; ++i)
                {
                    if (memory[i] != 0)
                    {
                        count = 0;
                    }
                    else
                    {
                        ++count;
                        if (count == size)
                        {
                            for (int j = i - count + 1; j <= i; ++j)
                            {
                                memory[j] = mID;
                            }
                            return i - count + 1;
                        }
                    }
                }
                return -1;
            }

            public int FreeMemory(int mID)
            {
                int count = 0;
                for (int i = 0; i < n; ++i)
                {
                    if (memory[i] == mID)
                    {
                        ++count;
                        memory[i] = 0;
                    }
                }
                return count;
            }


        }
    }

}
