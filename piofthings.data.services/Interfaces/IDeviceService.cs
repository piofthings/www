using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piofthings.Data.Services.Interfaces
{
    public interface IDeviceService
    {
        IEnumerable<Piofthings.Data.Models.Device> GetAllDevices(string user);
        Piofthings.Data.Models.Device GetDevice(int id);
        Piofthings.Data.Models.Device SaveDevice(Piofthings.Data.Models.Device device);
        bool DeleteDevice(int id);
        
    }
}
