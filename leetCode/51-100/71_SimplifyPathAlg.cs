using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _71_SimplifyPathAlg
    {
        public string SimplifyPath(string path)
        {
            string sss = path.Replace("/./", "/");
            while (sss.Contains("/./"))
            {
                sss = sss.Replace("/./", "/");
            }
            if (sss.EndsWith("/."))
            {
                sss = $"{sss}/".Replace("/./", "/");
            }
            var arr = sss.Split('/', StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> res = new List<string>();
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] != "..")
                {
                    res.Add(arr[i]);
                }
                else
                {
                    if (res.Count > 0)
                    {
                        res.RemoveAt(res.Count - 1);
                    }
                }
            }

            if (res.Count > 0)
            {
                string ss = $"/{string.Join("/", res)}";
                return ss;
            }
            return "/";
        }
    }
}
