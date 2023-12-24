using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _135_CandyAlg
    {
        public int Candy1(int[] ratings)
        {
            if (ratings.Length == 1)
                return 1;

            int index = 0;
            int total = 0;
            int len = ratings.Length - 1;

            DataModel lastModel = null;
            while (index < len)
            {
                int nextIndex = index + 1;
                int curr = ratings[index];
                int nextVal = ratings[nextIndex];
                if (nextVal > curr)
                {

                    var currModel = GetUpRangeNum(index, ratings, lastModel == null);

                    lastModel = currModel;
                    total += currModel.Sum;
                    index = currModel.Index + 1;
                    continue;
                }
                else if (nextVal < curr)
                {

                    var currModel = GetDownRangeNum(index, ratings);
                    if (lastModel != null)
                    {
                        if (lastModel.Status == 1)
                        {
                            if (lastModel.LastNum < currModel.LastNum)
                            {
                                total = total - lastModel.LastNum;
                                total += currModel.Sum;
                            }
                            else
                            {
                                total = total + currModel.Sum - currModel.LastNum;
                            }
                        }
                        else if (lastModel.Status == 0)
                        {
                            total -= lastModel.LastNum;
                            total += currModel.Sum;
                        }
                    }
                    else
                    {
                        total += currModel.Sum;
                    }

                    lastModel = currModel;
                    index = currModel.Index + 1;
                    continue;
                }
                else
                {
                    var currModel = GetEqualRangeNum(index, ratings, lastModel == null);
                    total += currModel.Sum;
                    lastModel = currModel;
                    index = currModel.Index + 1;
                    continue;

                }
            }
            return total;
        }
        class DataModel
        {
            public int Index;
            public int Sum;
            public int LastNum;
            public int Status;
            public DataModel(int index, int sum, int lastNum, int status)
            {
                this.Index = index;
                this.Sum = sum;
                this.LastNum = lastNum;
                this.Status = status;
            }
        }
        private DataModel GetUpRangeNum(int begin, int[] ratings, bool isFirst)
        {
            int len = ratings.Length - 1;
            int baseNum = 2;
            if (isFirst)
            {
                baseNum = 1;
            }
            int num = 0;
            int last = 0;
            int index = begin;
            int ln = 1;
            for (int i = begin; i < len; i++)
            {
                int curr = ratings[i];
                int nextIndex = i + 1;
                int next = ratings[nextIndex];
                if (curr < next)
                {
                    index = i;
                    ln++;
                }
                else
                {
                    break;
                }
            }
            if (!isFirst)
            {
                ln--;
            }
            for (int i = 0; i < ln; i++)
            {
                num += baseNum;
                last = baseNum;
                baseNum++;
            }

            DataModel model = new DataModel(index, num, last, 1);

            return model;
        }

        private DataModel GetEqualRangeNum(int begin, int[] ratings, bool isFirst)
        {
            int len = ratings.Length - 1;
            int num = 0;
            int index = begin;
            int ln = 1;
            for (int i = begin; i < len; i++)
            {
                int curr = ratings[i];
                int nextIndex = i + 1;
                int next = ratings[nextIndex];
                if (curr == next)
                {
                    index = i;
                    ln++;
                }
                else
                {
                    break;
                }
            }
            if (!isFirst)
            {
                ln--;
            }
            for (int i = 0; i < ln; i++)
            {
                num += 1;

            }

            DataModel model = new DataModel(index, num, 1, 0);
            return model;
        }

        private DataModel GetDownRangeNum(int begin, int[] ratings)
        {
            int len = ratings.Length - 1;
            int num = 0;
            int last = 0;
            int baseNum = 1;
            int index = begin;
            int ln = 1;
            for (int i = begin; i < len; i++)
            {
                int curr = ratings[i];
                int nextIndex = i + 1;
                int next = ratings[nextIndex];
                if (curr > next)
                {
                    index = i;
                    ln++;
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < ln; i++)
            {
                num += baseNum;
                last = baseNum;
                baseNum++;
            }

            DataModel model = new DataModel(index, num, last, -1);

            return model;
        }

        public int Candy2(int[] ratings)
        {
            int[] arr = new int[ratings.Length];
            int len = ratings.Length;
            for (int i = 0; i < len; i++)
            {
                if (i > 0 && ratings[i] > ratings[i - 1])
                {
                    arr[i] = arr[i - 1] + 1;
                }
                else
                {
                    arr[i] = 1;
                }
            }
            int right = 0, ret = 0;
            for (int i = len - 1; i >= 0; i--)
            {
                if (i < len - 1 && ratings[i] > ratings[i + 1])
                {
                    right++;
                }
                else
                {
                    right = 1;
                }
                ret += Math.Max(arr[i], right);
            }
            return ret;
        }
        public int Candy(int[] ratings)
        {
            int len = ratings.Length;
            int res = 1;
            int left = 1;
            int right = 0;
            int pre = 1;

            for (int i = 1; i < len; i++)
            {
                if (ratings[i] >= ratings[i - 1])
                {
                    right = 0;
                    pre = ratings[i] == ratings[i - 1] ? 1 : pre + 1;
                    res += pre;
                    left = pre;
                }
                else
                {
                    right++;
                    if (right == left)
                    {
                        right++;
                    }
                    res += right;
                    pre = 1;
                }


            }
            return res;
        }

    }
}
