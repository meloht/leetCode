using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0251_0300
{
    public class _278_FirstBadVersionAlg : VersionControl
    {
        public _278_FirstBadVersionAlg(int bad) : base(bad)
        {

        }

        public int FirstBadVersion(int n)
        {
            int left = 1, right = n;
            while (left < right)
            { // 循环直至区间左右端点相同
                int mid = left + (right - left) / 2; // 防止计算时溢出
                if (IsBadVersion(mid))
                {
                    right = mid; // 答案在区间 [left, mid] 中
                }
                else
                {
                    left = mid + 1; // 答案在区间 [mid+1, right] 中
                }
            }
            // 此时有 left == right，区间缩为一个点，即为答案
            return left;
        }

        public int FirstBadVersion1(int n)
        {
            int left = 1;
            int right = n;
            bool leftbl = IsBadVersion(left);
            if (leftbl)
            {
                return left;
            }

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (IsBadVersion(mid))
                {

                    int lmid = mid - 1;
                    if (lmid > 0)
                    {
                        if (IsBadVersion(lmid))
                        {
                            right = lmid;
                        }
                        else
                        {
                            return mid;
                        }
                    }
                }
                else
                {
                    int rmid = mid + 1;
                    if (rmid <= n)
                    {
                        if (IsBadVersion(rmid))
                        {
                            return rmid;
                        }
                        else
                        {
                            left = rmid;
                        }
                    }
                }

            }

            return -1;
        }
    }

    public class VersionControl
    {
        private int _bad;
        public VersionControl(int bad)
        {
            this._bad = bad;
        }
        public bool IsBadVersion(int version)
        {
            if (version >= _bad)
                return true;
            return false;
        }
    }



}
