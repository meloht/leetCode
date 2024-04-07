using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _312_BurstBalloonsAlg
    {
        public int MaxCoins(int[] nums)
        {

            int[][] arr=new int[nums.Length][];
            for (int i = 0; i < nums.Length; i++)
            {
                arr[i]= [nums[i], i];
            }
            Array.Sort(arr, (x, y) => x[0].CompareTo(y[0]));

            bool[] used=new bool[nums.Length];


            int ans = 0;


           
            return 0;
        }
    }
}
