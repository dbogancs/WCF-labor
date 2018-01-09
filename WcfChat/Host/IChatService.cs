using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Host
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IChatService" in both code and config file together.
    [ServiceContract(CallbackContract=typeof(IChatCallback))]
    public interface IChatService
    {
        [OperationContract]
        void Register(string name);

        [OperationContract]
        void Send(ChatMessage message);
    }

    public interface IChatCallback
    {
        [OperationContract]
        void Receive(ChatMessage message);
    }

    public class ChatMessage
    {
        public string Sender { get; set; }
        public string Target { get; set; }
        public string Message { get; set; }
    }
}
