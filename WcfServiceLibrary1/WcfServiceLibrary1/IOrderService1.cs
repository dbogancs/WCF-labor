using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOrderService1" in both code and config file together.
    [ServiceContract]
    public interface IOrderService1
    {
        [OperationContract]
        string NewOrder(Order order);
        //void DoWork();
    }

    public class Order
    {
        public int ProductId { get; set; }
        public int Count { get; set; }
        public string Message { get; set; }
    }
}
