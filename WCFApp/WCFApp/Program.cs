using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace WCFApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(CalculatorService), new Uri("http://localhost:8733/Design_Time_Addresses/Calc")))
            {
                host.AddServiceEndpoint(typeof(CalculatorService), new BasicHttpBinding(), "Calc");

                var mex = new ServiceMetadataBehavior{ HttpGetEnabled = true};
                host.Description.Behaviors.Add(mex);

                host.Open();
                Console.WriteLine("Service is up!");
                Console.ReadLine();
            }
        }
    }
}
