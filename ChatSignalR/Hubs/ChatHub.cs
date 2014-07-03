using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace ChatSignalR.Hubs
{
    public class ChatHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }

        /// <summary>
        /// The bellow section 
        ///call a function sendmessagetopage
        ///on all the clients that are connected
        /// </summary>
        /// <param name="name"></param>
        /// <param name="message"></param>
        public void Send(string name, string message)
        {
            Clients.All.SendMessageToPage(name, message);

           //test
        
        }
    }
}