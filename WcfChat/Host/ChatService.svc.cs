using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Host
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ChatService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ChatService.svc or ChatService.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single, ConcurrencyMode=ConcurrencyMode.Multiple)]
    public class ChatService : IChatService
    {
        ConcurrentDictionary<string, IChatCallback> clients = new ConcurrentDictionary<string, IChatCallback>();

        public void Register(string name)
        {
            clients.TryAdd(name, OperationContext.Current.GetCallbackChannel<IChatCallback>());
        }

        public void Send(ChatMessage message)
        {
            if (clients.TryGetValue(message.Target, out IChatCallback proxy))
            {
                proxy.Receive(message);
            }
        }

         

    }
}
