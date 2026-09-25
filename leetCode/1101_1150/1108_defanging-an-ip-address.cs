using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode._1101_1150
{
    public class _1108_defanging_an_ip_address
    {
        public string DefangIPaddr(string address)
        {

            return address.Replace(".","[.]");
        }
    }
}
