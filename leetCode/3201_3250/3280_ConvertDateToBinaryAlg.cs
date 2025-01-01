using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3201_3250
{
    public class _3280_ConvertDateToBinaryAlg
    {
        public string ConvertDateToBinary(string date)
        {

            string[] arr = date.Split('-');


            return $"{Convert.ToString(int.Parse(arr[0]), 2)}-{Convert.ToString(int.Parse(arr[1]), 2)}-{Convert.ToString(int.Parse(arr[2]), 2)}";
        }
    }
}
