using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1401_1450
{
    public class _1436_DestinationCityAlg
    {
        public string DestCity(IList<IList<string>> paths)
        {


            HashSet<String> setA = new HashSet<string>(); // 预分配空间
            foreach (var item in paths)
            {
                setA.Add(item[0]);
            }

            foreach (var p in paths)
            {
                if (!setA.Contains(p[1]))
                {
                    return p[1];
                }
            }
            return "";


        }
    }
}
