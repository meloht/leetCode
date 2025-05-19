using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace leetCode._51_100
{
    public class _75_SortColorsAlg
    {
        public void SortColors2(int[] nums)
        {
            int a = 0, b = 0, c = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    a++;
                }
                else if (nums[i] == 1)
                {
                    b++;
                }
                else
                {
                    c++;
                }
            }
            for (int i = 0; i < a; i++)
            {
                nums[i] = 0;
            }
            int len = a + b;
            for (int i = a; i < len; i++)
            {
                nums[i] = 1;
            }
            for (int i = len; i < nums.Length; i++)
            {
                nums[i] = 2;
            }
        }
        public void SortColors3(int[] nums)
        {
            Node node = new Node();
            for (int i = 0; i < nums.Length; i++)
            {
                int num1 = nums[i];

                Move(nums,num1,i,node);

            }

        }
        private void Move(int[] nums, int num1, int index, Node node)
        {
            if (num1 == 0)
            {
                node.a++;
            }
            if (num1 == 1)
            {
                node.b++;
            }
            if (num1 == 2)
            {
                node.c++;
            }
            for (int i = 0; i < node.a; i++)
            {
                nums[i] = 0;
            }
            int len = node.a + node.b;
            for (int i = node.a; i < len; i++)
            {
                nums[i] = 1;
            }
            
            for (int i = len; i <= index; i++)
            {
                nums[i] = 2;
            }

        }

        class Node
        {
            public int a = 0;
            public int b = 0;
            public int c = 0;
        }


        public void SortColors(int[] nums)
        {
            int p0 = 0;
            int p1 = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int x = nums[i];
                nums[i] = 2;
                if (x <= 1)
                {
                    nums[p1++] = 1;
                }
                if (x == 0)
                {
                    nums[p0++] = 0;
                }
            }

        }
    }
}
