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
        public bool Handshake()
        {
            return true;
        }

        public void SwitchOn(GpioId gpioPinId)
        {
            Console.WriteLine("Switching ON - " + gpioPinId.ToString("D"));
            Clients.Others.switchOn(gpioPinId);
        }

        public void switchOff(GpioId gpioPinId)
        {
            Console.WriteLine("Switching OFF - " + gpioPinId.ToString("D"));

            Clients.Others.switchOff(gpioPinId);
        }

    }
}
