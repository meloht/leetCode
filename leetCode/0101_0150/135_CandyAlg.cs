using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _135_CandyAlg
    {
        public int Candy(int[] ratings)
        {
            if (ratings.Length == 1)
                return 1;

            int total = 0;
            int len = ratings.Length - 1;

            int baseNum = 1;
            int preNum = 0;

            int status = -2;// equal:0, up:1, down:-1 
            for (int i = 0; i < len; i++)
            {
                int curr = ratings[i];
                int next = ratings[i + 1];
                if (curr < next)// up
                {
                    if (status == -2)
                    {
                        baseNum = 1;
                        total += baseNum;
                    }
                    else if (status == 1)
                    {
                        baseNum++;
                        total += baseNum;
                    }
                    else if (status == -1)
                    {
                        baseNum++;
                        preNum = baseNum;

                        total += baseNum;
                        baseNum = 1;


                    }
                    else if (status == 0)
                    {
                        preNum = baseNum;
                        baseNum = 1;
                        total += baseNum;
                    }
                    status = 1;
                }
                else if (curr == next) //equal
                {

                    if (status == -1)
                    {
                        baseNum++;
                        if (preNum < baseNum)
                        {
                            total += baseNum;
                        }
                        else
                        {
                            total += preNum;
                        }
                        preNum = baseNum;
                        baseNum = 1;

                    }
                    else if (status == -2)
                    {
                        baseNum = 1;
                        total += baseNum;
                    }
                    else if (status == 0)
                    {
                        preNum = 1;
                        baseNum = 1;
                        total += baseNum;

                    }
                    else if (status == 1)
                    {
                        baseNum++;
                        total += baseNum;
                        preNum = baseNum;
                        baseNum = 1;
                    }
                    status = 0;
                }
                else
                {

                    // down
                    if (status == -2)
                    {
                        baseNum = 1;
                        total += baseNum;
                    }
                    else if (status == 1)
                    {
                        baseNum++;
                        preNum = baseNum;
                    }
                    else if (status == 0)
                    {
                        baseNum = 1;
                        total += baseNum;
                    }
                    else if (status == -1)
                    {
                        baseNum++;
                        total += baseNum;
                    }
                    status = -1;
                }
            }

            if (status == 1)
            {
                baseNum++;
                total += baseNum;
            }
            else if (status == 0)
            {
                total += 1;
            }
            else
            {
                baseNum++;
                total += baseNum;
            }
            return total;
        }

    }
}
