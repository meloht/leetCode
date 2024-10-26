using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{
    public class _537_ComplexNumberMultiplicationAlg
    {
        public string ComplexNumberMultiply(string num1, string num2)
        {
            string[] complex1 = num1.Split(new char[2] { '+', 'i' });
            string[] complex2 = num2.Split(new char[2] { '+', 'i' });
            int real1 = int.Parse(complex1[0]);
            int imag1 = int.Parse(complex1[1]);
            int real2 = int.Parse(complex2[0]);
            int imag2 = int.Parse(complex2[1]);
            return $"{real1 * real2 - imag1 * imag2}+{real1 * imag2 + imag1 * real2}i";


        }
    }
}
