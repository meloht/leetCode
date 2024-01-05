using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1901_1950
{
    public class _1944_NumberOfVisiblePeopleInAQueueAlg
    {
        public int[] CanSeePersonsCount(int[] heights)
        {
            int[] res = new int[heights.Length];
            for (int i = 0; i < heights.Length; i++)
            {
                int count = 0;
                int max = 0;

                for (int j = i + 1; j < heights.Length; j++)
                {
                    if (max == 0)
                    {
                        if (heights[j] < heights[i])
                        {
                            count++;
                            max = heights[j];
                        }
                        else
                        {
                            count++;
                            break;
                        }
                    }
                    else
                    {
                        if (heights[j] > max && heights[j] < heights[i])
                        {
                            count++;
                            max = heights[j];
                        }
                        else if (heights[j] > max && heights[j] >= heights[i])
                        {
                            count++;
                            break;
                        }
                        else if (heights[j] <= max)
                        {
                            continue;
                        }
                    }

                }
                res[i] = count;
            }

            return res;
        }
    }
}
