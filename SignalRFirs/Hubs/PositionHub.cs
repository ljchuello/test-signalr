﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRFirs.Hubs
{
    public class PositionHub : Hub
    {
        public async Task SendPosition(int left, int top)
        {
            await Clients.Others.SendAsync("ReceivePosition", left, top);
        }
    }
}
