using Amazon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            //Amazon.RateCalculator cannot access cuz its internal
        }
    }
}
