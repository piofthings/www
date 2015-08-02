using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piofthings.Data.Services.Mappers
{
    public static class DeviceMapper
    {
        public static Piofthings.Domain.Models.Devices.Device Map(Piofthings.Data.Models.Device incomingDevice)
        {
            return new Domain.Models.Devices.Device
            {
                Id = incomingDevice.Id,
                Account = incomingDevice.Account,
                Identifier = incomingDevice.Identifier,
                Name = incomingDevice.Name
            };
        }

        public static Piofthings.Data.Models.Device Map(Piofthings.Domain.Models.Devices.Device incomingDevice)
        {
            return new Models.Device
            {
                Id = incomingDevice.Id,
                Account = incomingDevice.Account,
                Identifier = incomingDevice.Identifier,
                Name = incomingDevice.Name
            };
        }

        public static ICollection<Piofthings.Domain.Models.Devices.Device> MapCollection(IEnumerable<Piofthings.Data.Models.Device> incomingDevices)
        {
            return incomingDevices.Select<Piofthings.Data.Models.Device, Piofthings.Domain.Models.Devices.Device>(DeviceMapper.Map).ToArray();
        }

        public static ICollection<Piofthings.Data.Models.Device> MapCollection(IEnumerable<Piofthings.Domain.Models.Devices.Device> incomingDevices)
        {
            return incomingDevices.Select<Piofthings.Domain.Models.Devices.Device, Piofthings.Data.Models.Device>(DeviceMapper.Map).ToArray();
        }
    }
}
