using Piofthings.Data.Contexts;
using Piofthings.Data.Models;
using Piofthings.Data.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piofthings.Data.Services
{
    public class DeviceService : IDeviceService
    {
        private DeviceContext db = new DeviceContext();

        public IEnumerable<Piofthings.Data.Models.Device> GetAllDevices(string user)
        {
            return db.Devices.Where<Device>(d => d.Account == user);
        }

        public Piofthings.Data.Models.Device GetDevice(int id)
        {
            return db.Devices.Find(id);
        }

        public Piofthings.Data.Models.Device SaveDevice(Piofthings.Data.Models.Device device)
        {
            if(device.Id > 0)
            {
                db.Entry(device).State = EntityState.Modified;
                db.SaveChanges();
            }
            else
            {
                db.Devices.Add(device);
                db.SaveChanges();
            }
            return device;
        }


        public bool DeleteDevice(int id)
        {
            Device device = db.Devices.Find(id);
            db.Devices.Remove(device);
            var ret = db.SaveChanges();
            return ret == 1;
        }
    }
}
