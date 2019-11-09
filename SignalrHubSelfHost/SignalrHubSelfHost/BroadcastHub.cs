using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalrHubSelfHost
{
    public class BroadcastHub : Hub
    {
        [HubMethodName("Broadcast")]
        public void Broadcast()
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<BroadcastHub>();
            context.Clients.All.updatedClients();
        }
    }
}
