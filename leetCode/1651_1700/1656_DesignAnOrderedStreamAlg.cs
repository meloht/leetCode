using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1651_1700
{
    public class _1656_DesignAnOrderedStreamAlg
    {
        public class OrderedStream
        {
            string[] arr;
            int prt = 1;

            public OrderedStream(int n)
            {
                arr = new string[n + 1];
            }

            public IList<string> Insert(int idKey, string value)
            {
                arr[idKey] = value;
                List<string> list = new List<string>();
                while (prt < arr.Length && arr[prt] != null)
                {
                    list.Add(arr[prt]);
                    prt++;
                }
                return list;
            }
        }
    }
}
