using Piofthings.Domain.Interfaces;
using DataInterface = Piofthings.Data.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Piofthings.Data.Services.Mappers;
using System.Collections;

namespace Piofthings.Domain.Services
{
    public class DeviceServices : IDeviceServices
    {
        DataInterface.IDeviceService _deviceDataServices;
        public DeviceServices(DataInterface.IDeviceService deviceSataServices)
        {
            this._deviceDataServices = deviceSataServices;
        }

        public ICollection<Models.Devices.Device> GetAllDevices(string user)
        {
            var devices = DeviceMapper.MapCollection(this._deviceDataServices.GetAllDevices(user));
            return devices;
        }

        public Models.Devices.Device GetDevice(int deviceId, string user)
        {
            var device = this._deviceDataServices.GetDevice(deviceId);
            if (device.Account == user)
            {
                return DeviceMapper.Map(device);
            }
            else
            {
                return null;
            }
        }

        public Models.Devices.Device SaveDevice(Models.Devices.Device device)
        {
            
            var savedDevice = this._deviceDataServices.SaveDevice(DeviceMapper.Map(device));
            if(savedDevice != null)
            {
                return DeviceMapper.Map(savedDevice);
            }
            else
            {
                return null;
            }
        }

        public bool DeleteDevice(int deviceId, string user)
        {
            var device = this._deviceDataServices.GetDevice(deviceId);
            if (device.Account == user)
            {
                return this._deviceDataServices.DeleteDevice(deviceId);
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
        }
    }
}
