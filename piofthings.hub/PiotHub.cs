using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using PiOfThings.GpioUtils;

namespace piofthings.hub
{
    [HubName("PiotHub")]
    public class PiotHub : Hub
    {
        public string Handshake(string deviceId)
        {
            Groups.Add(this.Context.ConnectionId, deviceId);
            return deviceId;
        }

        public void SwitchOn(GpioId gpioPinId, string deviceId)
        {
            Console.WriteLine("Switching ON - " + gpioPinId.ToString("D"));
            Clients.Group(deviceId).switchOn(gpioPinId);
        }

        public void SwitchOff(GpioId gpioPinId, string deviceId)
        {
            Console.WriteLine("Switching OFF - " + gpioPinId.ToString("D"));
            Clients.Group(deviceId).switchOff(gpioPinId);
        }
    }
}
