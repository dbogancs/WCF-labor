using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OrderService1" in both code and config file together.
    public class OrderService1 : IOrderService1
    {

        public string NewOrder(Order order)
        {
            Console.WriteLine($"New Order: {order.ProductId}, Count: {order.Count}, {order.Message}");
            return "OK";
        }

        /*
        public void DoWork()
        {
        }
        */
    }
}
