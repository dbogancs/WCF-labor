using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFClient1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var proxy = new ServiceReference1.OrderService1Client())
            {
                Console.WriteLine(proxy.NewOrder(new ServiceReference1.Order { ProductId = 2, Count = 3, Message = "hello!" }));
                Console.ReadLine();
            }
        }
    }
}
