using Piofthings.Domain.Interfaces;
using Piofthings.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Piofthings.Compositionroot
{
    public class BootStrapperModule : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            RegisterServices(Kernel);
            Kernel.Bind<IDeviceServices>().To<DeviceServices>();
        }

        private void RegisterServices(Ninject.IKernel kernel)
        {
            kernel.Load(new[] 
            {
                Assembly.Load("Piofthings.Domain"),
                Assembly.Load("Piofthings.Domain.Models"),
                Assembly.Load("Piofthings.Data"),
                Assembly.Load("Piofthings.Data.Services"),
                Assembly.Load("Piofthings.Hub")
            });
        }
    }
}
