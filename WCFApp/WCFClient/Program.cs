using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var proxy = new ServiceReferenceCalc.CalculatorServiceClient())
            {
                Console.WriteLine(proxy.Add(3, 4));
            }
        }
    }
}
