using Piofthings.Domain.Models.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piofthings.Domain.Interfaces
{
    public interface IDeviceServices
    {
        ICollection<Device> GetAllDevices(string user);
        Device GetDevice(int deviceId, string user);
        Device SaveDevice(Device device);
        bool DeleteDevice(int deviceId, string user);
    }
}
